using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using DBConnectionClass;
using Sodv2101_Group13_BudgetApp.InputForms;
using Sodv2101_Group13_BudgetApp.RepositoryDBContext.ContributionServices;

namespace Sodv2101_Group13_BudgetApp.RepositoryDBContext.FinancialGoalsService
{
    internal class FinancialGoalService
    {
        private DBConnection dBConnection = new DBConnection();
        //private FinancialGoalService financialGoalService = new FinancialGoalService();
        private ContributionService contributionService = new ContributionService();

        public bool CreateFinancialGoal(FinancialGoal goal)
        {
            if(string.IsNullOrEmpty(goal.Name) || goal.MaxAmount <=0 || goal.Deadline == DateTime.MinValue)
            {
                throw new ArgumentException("Invalid financial goal data");
            }

            string query = "INSERT INTO FinancialGoal (Name, Amount, Description, Deadline, UserID) VALUES (@GoalName, @Amount, @Description, @Deadline, @UserID)";

            using(SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GoalName", goal.Name);
                        command.Parameters.AddWithValue("@Amount", goal.MaxAmount);
                        command.Parameters.AddWithValue("@Description", goal.Description ?? (object)DBNull.Value);
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
                    Console.WriteLine(ex.ToString());
                }
            }
            return false;
        }

        public bool EditFinancialGoal(FinancialGoal goal, int id)
        {
            if (string.IsNullOrEmpty(goal.Name) || goal.MaxAmount <= 0 || goal.Deadline == DateTime.MinValue)
            {
                throw new ArgumentException("Invalid financial goal data");
            }
            string query = "UPDATE FinancialGoal SET Name = @GoalName, Max = @Amount, Description = @Description, Deadline = @Deadline WHERE GoalID = @GoalID";

            using(SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using(SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GoalName", goal.Name);                        
                        command.Parameters.AddWithValue("@Amount", goal.MaxAmount);
                        command.Parameters.AddWithValue("@Description", goal.Description ?? (object)DBNull.Value);
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
                    Console.WriteLine(ex.ToString());
                }

            }                
              return false;
        }

        public bool DeleteFinancialGoal(int goalId)
        {
            if (goalId <= 0)
            {
                throw new ArgumentException("Invalid GoalID");
            }
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
//<<<<<<< Updated upstream
            //string query = "UPDATE FinancialGoal SET ";
//=======
            //string query1 = "UPDATE FinancialGoal SET ";
//>>>>>>> Stashed changes
            return false;
        }

        public DataTable GetFinancialGoalTable()
        {
            // default of 1 for now so that we can add login later if we want
            int UserID = 1;

            // might change this method to return a list of objects instead of a table
            // List<Budget> budgets = new List<Budget>();
            string query = "SELECT Name, Amount, Description, Deadline, GoalID FROM FinancialGoal WHERE UserID = @UserID";
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

        public List<FinancialGoal> GetFinancialGoalList()
        {
            // default of 1 for now so that we can add login later if we want
            int UserID = 1;
            // might change this method to return a list of objects instead of a table
            // List<Budget> budgets = new List<Budget>();
            string query = "SELECT GoalID, Name, Amount, Description, Deadline  FROM FinancialGoal WHERE UserID = @UserID";
            List<FinancialGoal> goalList = new List<FinancialGoal>();
            using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
               
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        SqlDataReader result = cmd.ExecuteReader();

                        while (result.Read())
                        {
                            FinancialGoal goal = new FinancialGoal
                            {
                                GoalID = Convert.ToInt32(result["GoalID"]),
                                Name = result["Name"].ToString(),
                                MaxAmount = Convert.ToDouble(result["Amount"]),
                                Description = result["Description"].ToString(),
                                Deadline = Convert.ToDateTime(result["Deadline"])
                            };
                            goal.Contributions = contributionService.GetContributionByGoalName(goal.Name);
                            goalList.Add(goal);

                        }



                        //foreach (FinancialGoal goal in goalList)
                        //{
                        //    goal.Contributions = contributionService.GetContributionByGoalName(goal.Name);
                        //}
                        // pull Expense data for each budget and load data into each budget list
                        
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            return goalList;
        }
    }
}
