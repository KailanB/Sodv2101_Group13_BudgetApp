using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBConnectionClass;
using Sodv2101_Group13_BudgetApp.InputForms;

namespace Sodv2101_Group13_BudgetApp.RepositoryDBContext.ContributionService
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
                        command.Parameters.AddWithValue("@GoalID", contribution.Name);
                        command.Parameters.AddWithValue("@Amount", contribution.Amount);
                        command.Parameters.AddWithValue("@Description", contribution.Description);
                        command.Parameters.AddWithValue("@Date", contribution.Deadline);
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
        //public bool UpdateContribution(Contribution contribution, int id)
        //{
        //    string query = "UPDATE Contribution SET GoalID = @GoalID, Amount = @Amount, Description = @Description, Deadline = @Deadline WHERE GoalID = @GoalID";

        //    using (SqlConnection connection = new SqlConnection(dBConnection.ConnectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            using (SqlCommand command = new SqlCommand(query, connection))
        //            {
        //                command.Parameters.AddWithValue("@GoalName", goal.Name);
        //                command.Parameters.AddWithValue("@Amount", goal.Max);
        //                command.Parameters.AddWithValue("@Description", goal.Description);
        //                command.Parameters.AddWithValue("@Deadline", goal.Deadline);
        //                command.Parameters.AddWithValue("@GoalID", id);

        //                int rowsAffected = command.ExecuteNonQuery();
        //                if (rowsAffected > 0)
        //                {
        //                    return true;
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.ToString);
        //        }

        //    }
        //    return false;
        //}

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

    }
}
