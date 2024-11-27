﻿using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Sodv2101_Group13_BudgetApp.DBConnectionClass;
using Sodv2101_Group13_BudgetApp.InputForms;


namespace Sodv2101_Group13_BudgetApp.RepositoryDBContext.BudgetServices
{
	internal class BudgetService
	{

		// Budget server has a connection string that it pulls from a class in the folder DBConnectionClass
		// ******** IMPORTANT ********* //
		// my class is SET TO GIT IGNORE because we do not want to keep overriding our OWN DATABASES!!
		// CREATE A  class within DBConnectionClass FOLDER named DBConnection
		// public string ConnectionString {  get; set; } = "Data Source = DESKTOP-516INJ7; Initial Catalog = Sodv2101_BudgetAppDB; Integrated Security = true; TrustServerCertificate=True";
		// paste this string into the class AS THE ONLY FIELD and replace with YOUR DB info
		// ************* IMPORTANT ****************// 
		private DBConnection dbConnection = new DBConnection();


		
		// BudgetSerive CREATE METHOD
		public bool CreateBudget(Budget budget)
		{
			// replace with necessary query string for whatever table
			string query = "INSERT INTO Budget VALUES (@BudgetName, @MaxAmount, @Description, @UserID)";

			using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
			{
				try
				{
					connection.Open();
					using (SqlCommand cmd = new SqlCommand(query, connection))
					{
						// get parameters from the budget object we created earlier and pass the field values as parameters
						cmd.Parameters.AddWithValue("@BudgetName", budget.Name);
						cmd.Parameters.AddWithValue("@MaxAmount", budget.Max);
						cmd.Parameters.AddWithValue("@Description", budget.Description);

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



		public DataTable GetBudgetTable()
		{
			// default of 1 for now so that we can add login later if we want
			int UserID = 1;

			// might change this method to return a list of objects instead of a table
			// List<Budget> budgets = new List<Budget>();
			string query = "SELECT BudgetName, MaxAmount, Description, budgetID FROM Budget WHERE UserID = @UserID";
			using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
			{
				try
				{
					connection.Open();
					using (SqlCommand cmd = new SqlCommand(query, connection))
					{
						cmd.Parameters.AddWithValue("@UserID", 1);
						SqlDataReader result = cmd.ExecuteReader();
						DataTable budgetTable = new DataTable();
						budgetTable.Load(result);

						return budgetTable;

					}
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.ToString());
				}
			}

			return null;



		}


		public bool DeleteBudget(int budgetId)
		{
			string query = "DELETE FROM Budget WHERE budgetID = @budgetId";
			using (SqlConnection connection = new SqlConnection(dbConnection.ConnectionString))
			{
				try
				{
					connection.Open();
					using (SqlCommand cmd = new SqlCommand(query, connection))
					{
						cmd.Parameters.AddWithValue("@budgetId", budgetId);
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