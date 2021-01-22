using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teszt.Entities
{
    public class Kozet : Entity
    {
        public int Id { get; set; }
        public string Nev { get; set; }

        public Kozet(DataRow dataRow)
        {
            Id = Convert.ToInt32(dataRow[0]);
            Nev = Convert.ToString(dataRow[1]);            
        }

        public Kozet(string nev)
        {
            Nev = nev;
        }

        public override void CreateItself()
        {
            string query = "INSERT INTO kozetek (nev) VALUES (@Nev)";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);
                cmd.CommandText = query;

                cmd.Parameters.Add(new MySqlParameter("@Nev", MySqlDbType.VarChar));
                cmd.Parameters["@Nev"].Value = this.Nev;
                

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }
        public override void DeleteItself()
        {
            string query = "DELETE FROM kozetek WHERE id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);

                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                cmd.Parameters["@Id"].Value = this.Id;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }
        public override void UpdateItself()
        {
            string query = "UPDATE torpek set nev = @Nev, klan = @Klan, nem = @Nem, suly = @Suly, magassag = @magassag WHERE id = @Id";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);
                cmd.CommandText = query;

                cmd.Parameters.Add(new MySqlParameter("@Id", MySqlDbType.VarChar));
                cmd.Parameters["@Id"].Value = this.Id;

                cmd.Parameters.Add(new MySqlParameter("@Nev", MySqlDbType.VarChar));
                cmd.Parameters["@Nev"].Value = this.Nev;
                
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }

        //static read
        public static Kozet GetById(int id)
        {
            string query = "SELECT * from kozetek WHERE id = @Id";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);

                cmd.Parameters.Add(new MySqlParameter("@Id", MySqlDbType.VarChar));
                cmd.Parameters["@Id"].Value = id;

                using (DataTable dataTable = new DataTable())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        return new Kozet(dataTable.Rows[0]);
                    }

                    return null;
                }
            }
        }

        public static List<Kozet> GetAll()
        {
            string query = "SELECT * from kozetek";

            List<Kozet> kozetek = new List<Kozet>();

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);

                using (DataTable dataTable = new DataTable())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            kozetek.Add(new Kozet(row));
                        }

                        return kozetek;
                    }

                    return null;
                }
            }
        }



        public override void Validation()
        {
            throw new NotImplementedException();
        }
    }
}
