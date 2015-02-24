using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentApp.DAL.Gateway
{
    public class Gateway
    {
         private SqlConnection connectionObj;
        private SqlCommand commandObj;

        public Gateway()
        {
            connectionObj = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentApp"].ConnectionString);
            commandObj = new SqlCommand();
        }

        public SqlConnection SqlConnectionObj
        {
            get
            {
                return connectionObj;
            }
        }

        public SqlCommand SqlCommandObj
        {
            get
            {
                commandObj.Connection = connectionObj;
                return commandObj;
            }
        }
    }
}
