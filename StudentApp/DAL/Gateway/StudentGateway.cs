using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StudentApp.DAL.Gateway
{
    public class StudentGateway:Gateway
    {
        public bool ShowStudentInfo()
        {
            try
            {
                SqlConnectionObj.Open();
                SqlCommandObj.Connection = SqlConnectionObj;
                string query = String.Format("SELECT * FROM tblStudent");
                SqlCommandObj.CommandText = query;
                SqlDataReader reader = SqlCommandObj.ExecuteReader();
                if (reader != null)
                {
                    return reader.Read();
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Information couldn't loaded from your system", ex);
            }
            finally
            {
                if (SqlConnectionObj != null && SqlConnectionObj.State == ConnectionState.Open)
                {
                    SqlConnectionObj.Close();
                }
            }
        }
    }
}
