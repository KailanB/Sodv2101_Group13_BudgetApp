using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ExpenseServices;
using Sodv2101_Group13_BudgetApp.DBConnectionClass;
using Microsoft.VisualBasic.ApplicationServices;
using Sodv2101_Group13_BudgetApp.SubPageForms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sodv2101_Group13_BudgetApp.RepositoryDBContext.DBIncome
{
    internal class IncomeService
    {


        private DBConnection dbConnection = new DBConnection();




        public List<Income> GetIncomeList()
        {
            // default of 1 for now so that we can add login later if we want
            int UserID = 1;
            string query = "SELECT IncomeID, Name, Amount, IncomeTypeID FROM Income WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                List<Income> incomeList = new List<Income>();
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        SqlDataReader result = cmd.ExecuteReader();

                        while (result.Read())
                        {
                            // this refers to IncomeTypeID Where 1 = Salary
                            if ((Int32)result[3] == 1)
                            {
                                incomeList.Add(new IncomeSalary((Int32)result[0], result[1].ToString(), double.Parse(result[2].ToString()), (Int32)result[3], UserID));
                            }
                            // else income is hourly
                            else
                            {
                                incomeList.Add(new IncomeHourly((Int32)result[0], result[1].ToString(), double.Parse(result[2].ToString()), (Int32)result[3], UserID));
                            }

                        }

                        foreach (Income income in incomeList)
                        {
                            income.Type = GetIncomeTypeById(income.TypeID);
                        }


                        foreach (Income income in incomeList)
                        {

                            if(income is IncomeHourly)
                            {
                                var incomeHourly = income as IncomeHourly;
                                incomeHourly.HoursList = GetHoursById(income.IncomeId);
                            }
                           
                        }
                        return incomeList;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return null;


        }


        public bool CreateIncome(Income income)
        {
            string query = "INSERT INTO Income VALUES (@IncomeName, @Amount, @IncomeTypeID, @UserID)";

            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // get parameters from the budget object we created earlier and pass the field values as parameters
                        cmd.Parameters.AddWithValue("@IncomeName", income.Name);
                        cmd.Parameters.AddWithValue("@Amount", income.Amount);
                        cmd.Parameters.AddWithValue("@IncomeTypeID", income.TypeID);

                        cmd.Parameters.AddWithValue("@UserID", 1); // using a default user 1 at the moment
                                                                   // execute command
                        int rowsAffected = cmd.ExecuteNonQuery();
                        // if rows are affected return true
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        // else return false or catch error.

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return false;
        }
        public bool EditIncome(Income income, int id)
        {

            string query = "UPDATE Income SET Name = @IncomeName, Amount = @Amount, IncomeTypeID = @IncomeTypeID WHERE IncomeID = @IncomeID";

            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IncomeName", income.Name);
                        cmd.Parameters.AddWithValue("@Amount", income.Amount);
                        cmd.Parameters.AddWithValue("@IncomeTypeID", income.TypeID);

                        cmd.Parameters.AddWithValue("@IncomeID", id); // income to be updated
                                                                      // execute command
                        int rowsAffected = cmd.ExecuteNonQuery();
                        // if rows are affected return true
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                        // else return false or catch error.

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return false;
        }


        public bool DeleteIncome(int id)
        {
            string query = "DELETE FROM Income WHERE IncomeID = @incomeId";
            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@incomeId", id);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return false;
        }


        public string GetIncomeTypeById(int id)
        {
            string idType = "";

            string query = "SELECT Type FROM IncomeType WHERE TypeID = @TypeId";
            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                List<Income> incomeList = new List<Income>();
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@TypeId", id);
                        SqlDataReader result = cmd.ExecuteReader();

                        while (result.Read())
                        {
                            idType = result[0].ToString();
                        }
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }


            return idType;

        }

        public List<IncomeType> GetIncomeTypeList()
        {
            //List<IncomeType> incomeTypes = new List<IncomeType>();

            string query = "SELECT TypeID, Type FROM IncomeType";
            using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
            {
                List<IncomeType> incomeTypes = new List<IncomeType>();
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader result = cmd.ExecuteReader();

                        while (result.Read())
                        {
                            incomeTypes.Add(new IncomeType((Int32)result[0], result[1].ToString()));

                        }
                        return incomeTypes;
                        // pull Expense data for each budget and load data into each budget list

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return null;

        }


        public List<HoursWorked> GetHoursById(int id)
        {

            List<HoursWorked> hoursWorked = new List<HoursWorked>();


            SqlConnection con = new SqlConnection(dbConnection.ConnectionString);
            string query = "SELECT HoursID, Hours, Date, IncomeID FROM HoursWorked WHERE IncomeID = @incomeID";

            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@incomeID", id);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    hoursWorked.Add(new HoursWorked((Int32)reader[0], double.Parse(reader[1].ToString()), (DateTime)reader[2], (Int32)reader[0]));

                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


            return hoursWorked;


        }




    }
}
