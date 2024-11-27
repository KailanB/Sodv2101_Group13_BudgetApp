using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;// to create a data table we need this library
using System.Data.SqlClient; // to use the database


namespace DBConnectionClass
{
    public class DBConnection
    {
        // Connection string for the database
        public string ConnectionString { get; set; } = "Data Source = DESKTOP-516INJ7; Initial Catalog = Sodv2101_BudgetAppDB; Integrated Security = true; TrustServerCertificate=True";
    }
}