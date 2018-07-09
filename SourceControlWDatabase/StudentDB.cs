using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlWDatabase
{
    class StudentDB
    {
        public static void DeleteStudent(int id)
        {
            SqlConnection con = new SqlConnection("con string here...");
            SqlCommand delCmd = new SqlCommand();

            delCmd.Connection = con;
            delCmd.CommandText = "DELETE QUERY";

            try
            {
                con.Open();
                int rows = delCmd.ExecuteNonQuery();
            }

            catch // we should catch specific 
            {
                // empty catch typically not a good idea
            }

            finally
            {
                con.Dispose(); // this calls close internally
            }

            // remove unused catch
            try
            {
                con.Open();
                // cont code here
            }
            finally
            {
                con.Dispose();
            }

            // using statement
            // generates try/finally block  
            // inside the finally, Dispose() is called
            using(SqlConnection con2 = new SqlConnection())
            {
                con2.Open();
                // other db code here...
                // if exception occurs, we can handle this in the forms
            } // dispose() is automatically called at the end 
        }
    }
}
