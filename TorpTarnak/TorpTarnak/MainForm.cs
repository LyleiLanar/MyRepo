using MySqlConnector;
using System;
using System.Text;
using System.Windows.Forms;

namespace TorpTarnak
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DBConnector connector = new DBConnector();

            string query = "SELECT * FROM torpek;";

            MySqlCommand cmd = new MySqlCommand(query, connector.Connection);

            connector.Connect();
            MySqlDataReader reader = cmd.ExecuteReader();

            StringBuilder sb = new StringBuilder();

            while (reader.Read())
            {
                sb.Append(reader.GetInt32(0).ToString());
                sb.Append(" | ");
                sb.Append(reader.GetString(1));
                sb.Append(" | ");
                sb.Append(reader.GetString(2));
                sb.Append(" | ");
                sb.Append(reader.GetString(3));
                sb.Append(" | ");
                sb.Append(reader.GetInt32(4).ToString());
                sb.Append(" | ");
                sb.Append(reader.GetInt32(5).ToString());
                sb.AppendLine();
            }
            
                textBox_torpokSzama.Text += sb.ToString();
            connector.Close();


        }
        private static string DisplayData(System.Data.DataTable table)
        {
            StringBuilder sb = new StringBuilder();

            foreach (System.Data.DataRow row in table.Rows)
            {
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    sb.Append($"{col.ColumnName} = {row[col]} \r\n");
                }
                sb.Append("============================");
            }

            return sb.ToString();
        }

    }
}
