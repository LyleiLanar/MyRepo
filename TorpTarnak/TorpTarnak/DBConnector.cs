using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorpTarnak
{
    class DBConnector
    {
        public string Constring { get; private set; }

        public MySqlConnection Connection { get; private set; }
        public DBConnector()
        {
            this.Constring = "server=localhost;user id=root;database=torpetarna";
            this.Connection = new MySqlConnection(Constring);
        }

        public void Connect()
        {
            Connection.Open();   
        }

        public void Close()
        {
            Connection.Close();
        }    
    }
}
