using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
  
namespace JewellStore
{
    public class dbClass
    {

        SqlConnection sqlConn;
        String connection_String = "Data Source=LAPTOP-LBI62H71\\SQLEXPRESS;Initial Catalog=JewelDB;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;


        //this statement is related to insert delete update query that is the main statement of any database record 
        public void record(String sqlStatement)
        {

            sqlConn = new SqlConnection(connection_String);
            sqlConn.Open();


            sqlCmd = new SqlCommand(sqlStatement, sqlConn);
            sqlCmd.ExecuteNonQuery();

            sqlConn.Close();

        }

        // this code is used to in the details of a prticuar query from the table using the sql statement with the help of where clause 
        public DataTable getRecord(String qry)
        {
            DataTable tbl = new DataTable();


            sqlConn = new SqlConnection(connection_String);

            sqlConn.Open();
            sqlCmd = new SqlCommand(qry, sqlConn);

            sqlDatareader = sqlCmd.ExecuteReader();

            tbl.Load(sqlDatareader);

            sqlConn.Close();

            return tbl;
        }



    }
}