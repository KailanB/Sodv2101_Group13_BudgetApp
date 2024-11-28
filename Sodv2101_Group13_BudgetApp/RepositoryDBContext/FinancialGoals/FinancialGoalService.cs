using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.DBConnectionClass;
using Sodv2101_Group13_BudgetApp.InputForms;

namespace Sodv2101_Group13_BudgetApp.RepositoryDBContext.FinancialGoals
{
    internal class FinancialGoalService
    {
        private DBConnection dBConnection = new DBConnection();

        public bool CreateFinancialGoal(FinancialGoal goal)
        {
            string query = "INSERT INTO FinancialGoal VALUES (@GoalName, @Amount, @Description, @Deadline, @UserID)";

            using(SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GoalName", goal.Name);
                        command.Parameters.AddWithValue("@Amount", goal.Max);
                        command.Parameters.AddWithValue("@Description", goal.Description);
                        command.Parameters.AddWithValue("@Deadline", goal.Deadline);
                        command.Parameters.AddWithValue("@UserID", 1);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString);
                }
            }
            return false;
        }

        public bool EditFinancialGoal(FinancialGoal goal, int id)
        {
            string query = "UPDATE FinancialGoal SET Name = @GoalName, Max = @Amount, Description = @Description, Deadline = @Deadline WHERE GoalID = @GoalID";

            using(SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GoalName", goal.Name);                        
                        command.Parameters.AddWithValue("@Amount", goal.Max);
                        command.Parameters.AddWithValue("@Description", goal.Description);
                        command.Parameters.AddWithValue("@Deadline", goal.Deadline);
                        command.Parameters.AddWithValue("@GoalID", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            return true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString);
                }

            }                
              return false;
        }

        public bool DeleteFinancialGoal(int goalId)
        {
            string query = "DELETE FROM FinancialGoal WHERE GoalID = @GoalID";
            using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@GoalID", goalId);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
<<<<<<< Updated upstream
            //string query = "UPDATE FinancialGoal SET ";
=======
            string query1 = "UPDATE FinancialGoal SET ";
>>>>>>> Stashed changes
            return false;
        }

        public DataTable GetBudgetTable()
        {
            // default of 1 for now so that we can add login later if we want
            int UserID = 1;

            // might change this method to return a list of objects instead of a table
            // List<Budget> budgets = new List<Budget>();
            string query = "SELECT Name, Max, Description, GoalID FROM FinancialGoal WHERE UserID = @UserID";
            using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        SqlDataReader result = cmd.ExecuteReader();
                        DataTable GoalTable = new DataTable();
                        GoalTable.Load(result);

                        return GoalTable;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }

            return null;



        }

    }
}
