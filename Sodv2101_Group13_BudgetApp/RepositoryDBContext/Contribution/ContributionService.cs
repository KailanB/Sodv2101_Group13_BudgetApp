using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sodv2101_Group13_BudgetApp.InputForms;
using System.Data.Common;
using Sodv2101_Group13_BudgetApp.DBConnectionClass;
using System.Data;

namespace Sodv2101_Group13_BudgetApp.RepositoryDBContext.ContributionServices
{
    internal class ContributionService
    {
        private DBConnection dBConnection = new DBConnection();

        public bool AddContribution(Contribution contribution)
        {
            string query = "INSERT INTO Contribution VALUES (@GoalID, @Amount, @Description, @Date)";

            using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@GoalID", contribution.GoalID);
                        command.Parameters.AddWithValue("@Amount", contribution.Amount);
                        command.Parameters.AddWithValue("@Description", contribution.Description);
                        command.Parameters.AddWithValue("@Date", contribution.Date);
                        //command.Parameters.AddWithValue("@UserID", 1); Not sure if this is needed or not 

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

        //----------------------------------------------------------------
        // Kinda Confused about this
        //----------------------------------------------------------------
        public bool UpdateContribution(Contribution contribution, int id)
        {
            
            string query = "UPDATE Contribution SET GoalID = @GoalID, Amount = @Amount, Description = @Description, Date = @Date WHERE ContributionID = @ContributionID";

            using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Set parameters based on Contribution class properties
                        command.Parameters.AddWithValue("@GoalID", contribution.GoalID);
                        command.Parameters.AddWithValue("@Amount", contribution.Amount);
                        command.Parameters.AddWithValue("@Description", contribution.Description);
                        command.Parameters.AddWithValue("@Date", contribution.Date);
                        command.Parameters.AddWithValue("@ContributionID", id);

                        // Execute the query and check rows affected
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Log the exception (or rethrow it based on your needs)
                    Console.WriteLine(ex.ToString());
                }
            }

            return false;
        }


        public bool RemoveContribution(int ContributionID)
        {
            string query = "DELETE FROM Contribution WHERE ContributionID = @ContributionID";
            using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ContributionID", ContributionID);
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
        public List<Contribution> GetContributionByGoalName(string goalName)
        {
            List<Contribution> contributions = new List<Contribution>();

            SqlConnection con = new SqlConnection(dBConnection.ConnectionString);
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT ContributionID, fg.GoalID, c.Amount, c.Description, Date FROM Contribution c JOIN FinancialGoal fg ON c.GoalID = fg.GoalID WHERE fg.Name = @goalName", con);
                cmd.Parameters.AddWithValue("@goalName", goalName);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    contributions.Add(new Contribution(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), double.Parse(reader[2].ToString()), reader[3].ToString(), (DateTime)reader[4]));                    
                }
                reader.Close();
                                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


            return contributions;

        }
        public List<Contribution> GetContributionList(int goalID)
        {
            List<Contribution> contributions = new List<Contribution>();
            string query = "SELECT ContributionID, GoalID, Amount, Description, Date FROM Contribution WHERE GoalID = @GoalID";

            using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@GoalID", goalID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                contributions.Add(new Contribution((Int32)reader[0], (Int32)reader[1], double.Parse(reader[2].ToString()), reader[3].ToString(), Convert.ToDateTime(reader[4].ToString())));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading contributions: {ex.Message}");
                }
            }
            return contributions;
        }
        //public List<Contribution> GetFinancialGoalList()
        //{
        //    // default of 1 for now so that we can add login later if we want
        //    int GoalID = 1;
        //    // might change this method to return a list of objects instead of a table
        //    // List<Budget> budgets = new List<Budget>();
        //    string query = "SELECT ContributionID, GoalID, Amount, Description, Deadline  FROM Contribution WHERE GoalID = @GoalID";
        //    List<Contribution> contributionList = new List<Contribution>();
        //    using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
        //    {

        //        try
        //        {
        //            connection.Open();
        //            using (SqlCommand cmd = new SqlCommand(query, connection))
        //            {
        //                cmd.Parameters.AddWithValue("@GoalID", GoalID);
        //                SqlDataReader result = cmd.ExecuteReader();

        //                while (result.Read())
        //                {
        //                    Contribution contribution = new Contribution
        //                    {
        //                        ContributionID = Convert.ToInt32(result["ContributionID"]),
        //                        GoalID = Convert.ToInt32(result["GoalID"]),
        //                        Amount = Convert.ToDouble(result["Amount"]),
        //                        Description = result["Description"].ToString(),
        //                        Deadline = Convert.ToDateTime(result["Deadline"])
        //                    };
        //                    goal.Contributions = contributionService.GetContributionByGoalName(goal.Name);
        //                    goalList.Add(goal);

        //                }



        //                //foreach (FinancialGoal goal in goalList)
        //                //{
        //                //    goal.Contributions = contributionService.GetContributionByGoalName(goal.Name);
        //                //}
        //                // pull Expense data for each budget and load data into each budget list

        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.ToString());
        //        }
        //    }
        //    return goalList;
        //}
    }
}
