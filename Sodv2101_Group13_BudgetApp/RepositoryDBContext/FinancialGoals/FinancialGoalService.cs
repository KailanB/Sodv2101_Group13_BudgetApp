using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Sodv2101_Group13_BudgetApp.DBConnectionClass;
using Microsoft.Data.SqlClient;
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
            string query = "UPDATE FinancialGoal SET ";
            return false;
        }
    }
}
