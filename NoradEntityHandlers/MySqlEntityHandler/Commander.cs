using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace MySqlEntityHandler
{
    public class Commander
    {
        public string CommandString { get; set; }
        private MySqlCommand _cmd;
        private string _connString;

        public Commander()
        {
            _connString = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            CommandString = "empty";
        }

        //Executes a non-query command (C U D).
        public void ExecuteNonQuery()
        {
            if (!CommandString.Equals("empty"))
            {
                using (MySqlConnection con = new MySqlConnection(_connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(CommandString, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                throw new System.Exception("Empty SQL command string!");
            }
        }

        //Executes a query command (R commands).
        public DataTable ExecuteQuery()
        {
            DataTable dataTable = new DataTable();

            using (MySqlConnection con = new MySqlConnection(_connString))
            {
                using (MySqlCommand cmd = new MySqlCommand(CommandString, con))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        public void DisposeCommand()
        {
            _cmd.Dispose();
        }
    }
}
