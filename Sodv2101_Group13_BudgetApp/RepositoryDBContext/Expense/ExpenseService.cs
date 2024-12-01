
using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.DBConnectionClass;
using System.Data;
using System.Data.Common;
using System.Security.Policy;
using System.Windows.Forms;



namespace Sodv2101_Group13_BudgetApp.RepositoryDBContext.ExpenseServices
{ 
    internal class ExpenseService
    {
        private DBConnection dbConnection = new DBConnection();

        // Method to create a new expense
        public bool NewExpense(Expense expense)
        {
            string query = "INSERT INTO Expense (BudgetID, Name, Amount, Description, PurchaseDate ) VALUES (@BudgetID, @Name, @Amount, @Description, @TimePeriod)";

            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        //        cmd.Parameters.AddWithValue("@Name", expense.Name);
                        //        cmd.Parameters.AddWithValue("@Amount", expense.Amount);
                        //        cmd.Parameters.AddWithValue("@Description", expense.Description);
                        //        cmd.Parameters.AddWithValue("@TimePeriod", expense.DateString);
                        //        cmd.Parameters.AddWithValue("@BudgetID", expense.BudgetId);

                        //        int rowsAffected = cmd.ExecuteNonQuery();
                        //        return rowsAffected > 0;
                        //    }
                        //}
                        //catch (Exception ex)
                        //{
                        //    MessageBox.Show("Error adding new expense: " + ex.Message);
                        //    return false;
                        //} // Add parameters for the SQL query

                        //Added to get edit button to workk nov 11:22 pm
                        cmd.Parameters.AddWithValue("@BudgetId", expense.BudgetId);  // BudgetId is used as a foreign key
                        cmd.Parameters.AddWithValue("@Name", expense.Name);
                        cmd.Parameters.AddWithValue("@Amount", expense.Amount);
                        cmd.Parameters.AddWithValue("@Description", expense.Description);

                        // Pass TimePeriod from the Expense object
                        cmd.Parameters.AddWithValue("@TimePeriod", expense.DateString);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0; // Return true if insert was successful
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return false; // Return false if there was an error
                }


            }
        }


        public bool UpdateExpense(Expense expense, int budgetId)
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
                        cmd.Parameters.AddWithValue("@TimePeriod", expense.DateString);

                        //        // Execute the query and check rows affected
                        //        int rowsAffected = cmd.ExecuteNonQuery();
                        //        return rowsAffected > 0;
                        //    }
                        //}
                        //catch (Exception ex)
                        //{
                        //    Console.WriteLine("Error updating expense: " + ex.Message);
                        //    return false;
                        //}

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Error updating expense: " + ex.Message);
                //    return false;
                //}
                catch (SqlException ex) when (ex.Number == 547) // Foreign key violation
                {
                    MessageBox.Show("The selected budget is not valid. Please select a valid budget.");
                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
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
                    expenses.Add(new Expense((Int32)reader[0], (Int32)reader[1], reader[2].ToString(), double.Parse(reader[3].ToString()), reader[4].ToString(), (DateTime)reader[5]));


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


			return expenses;

        }


        //NEED TO GIFURE THE DELETION OUT NOV 11:24pm


        //public bool DeleteExpense(int expenseID)
        //{
        //     string query = "DELETE FROM Expense WHERE ExpenseId = @expenseID";
        //using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
        //{
        //    try
        //    {
        //        connection.Open();
        //        using (SqlCommand cmd = new SqlCommand(query, connection))
        //        {
        //            cmd.Parameters.AddWithValue("@expenseID", expenseID);
        //            cmd.ExecuteNonQuery();
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //    }
        //}
        //return false;
        //}


        //POSSIBLE PARSING TO INMSERT EXPENSE TO DATABASE AFTER EDITED NOV 30 11:25pm
        //public bool InsertExpense(Expense expense)
        //{
        //    string query = "INSERT INTO Expenses (BudgetId, Name, Amount, Description, TimePeriod) " +
        //                   "VALUES (@BudgetId, @Name, @Amount, @Description, @TimePeriod)";

        //    using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
        //    {
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.Parameters.AddWithValue("@BudgetId", expense.BudgetId);
        //            command.Parameters.AddWithValue("@Name", expense.Name);
        //            command.Parameters.AddWithValue("@Amount", expense.Amount);
        //            command.Parameters.AddWithValue("@Description", expense.Description);
        //            command.Parameters.AddWithValue("@TimePeriod", expense.DateString);

        //            connection.Open();
        //            int result = command.ExecuteNonQuery();
        //            return result > 0;
        //        }
        //    }
        //}

    }
}
