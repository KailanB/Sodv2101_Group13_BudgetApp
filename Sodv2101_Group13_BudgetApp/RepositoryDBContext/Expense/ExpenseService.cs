using DBConnectionClass;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;



namespace Sodv2101_Group13_BudgetApp.RepositoryDBContext.ExpenseService
{ 
    internal class ExpenseService
    {
        private DBConnection dbConnection = new DBConnection();

        // Method to create a new expense
        public bool NewExpense(Expense expense)
        {
            string query = "INSERT INTO Expense (Name, Amount, Description, TimePeriod) VALUES (@Name, @Amount, @Description, @TimePeriod)";

            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Name", expense.Name);
                        cmd.Parameters.AddWithValue("@Amount", expense.Amount);
                        cmd.Parameters.AddWithValue("@Description", expense.Description);
                        cmd.Parameters.AddWithValue("@TimePeriod", expense.TimePeriod);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding new expense: " + ex.Message);
                    return false;
                }
            }
        }


        public bool UpdateExpense(Expense expense)
        {
            string query = "UPDATE Expense SET Name = @Name, Amount = @Amount, Description = @Description, TimePeriod = @TimePeriod WHERE ExpenseId = @ExpenseId";

            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Set parameters for the SQL query
                        cmd.Parameters.AddWithValue("@ExpenseId", expense.ExpenseId);
                        cmd.Parameters.AddWithValue("@Name", expense.Name);
                        cmd.Parameters.AddWithValue("@Amount", expense.Amount);
                        cmd.Parameters.AddWithValue("@Description", expense.Description);
                        cmd.Parameters.AddWithValue("@TimePeriod", expense.TimePeriod);

                        // Execute the query and check rows affected
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating expense: " + ex.Message);
                    return false;
                }
            }
        }


        public List<Expense> GetExpenseByBudgetId(int budgetId)
        {
            List<Expense> expenses = new List<Expense>();

			SqlConnection con = new SqlConnection(dbConnection.ConnectionString);
			try
			{
				con.Open();

				SqlCommand cmd = new SqlCommand("SELECT ExpenseID, BudgetID, Name, Amount, Description, PurchaseDate FROM Expense WHERE BudgetID = @budgetID", con);
                cmd.Parameters.AddWithValue("@budgetID", budgetId);

				SqlDataReader reader = cmd.ExecuteReader();
				while (reader.Read())
				{
                    expenses.Add(new Expense((Int32)reader[0], (Int32)reader[1], reader[2].ToString(), double.Parse(reader[3].ToString()), reader[4].ToString(), reader[5].ToString()));


					//Console.WriteLine("\t{0}\t{1}\t{2}",
					//reader[0], reader[1], reader[2]);
				}
				reader.Close();







				//SqlDataAdapter da = new SqlDataAdapter(cmd);
				//DataTable dt = new DataTable();
				//da.Fill(dt);

				// dataGridViewExpenses.DataSource = dt;

				//con.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}

            MessageBox.Show("In Expense service: " + expenses.Count.ToString());

			return expenses;

        }




    }
}
