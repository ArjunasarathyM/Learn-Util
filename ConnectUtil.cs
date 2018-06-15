using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BasicUtil{
    //Will see in bit bucket
    public class ConnectUtil{
        public SqlConnection sqlCon;
        string connectKey="";
        public void commit() {

        }
        public ConnectUtil()
        {
            foreach (ConnectionStringSettings connStr in ConfigurationManager.ConnectionStrings) {
                connectKey = connStr.ConnectionString;
            }
            sqlCon = new SqlConnection(connectKey);
            try {
                sqlCon.Open();
            }
            catch (Exception ex){
                Console.WriteLine(ex.ToString());
            }
        }
        public void destroy(){
            sqlCon.Close();
        }
    }
}