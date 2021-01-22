using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Teszt.Entities
{
    public class Tarna : Entity
    {

        public int Id { get; set; }
        public string Nev { get; set; }
        public int Kozet_id { get; set; }


        public Tarna(string nev, int kozet_id)
        {
            Nev = nev;
            Kozet_id = kozet_id;
        }
        public Tarna(DataRow dataRow)
        {
            Id = Convert.ToInt32(dataRow[0]);
            Nev = Convert.ToString(dataRow[1]);
            Kozet_id = Convert.ToInt32(dataRow[2]);
        }

        public override void CreateItself()
        {
            string query = "INSERT INTO tarnak (nev, kozet_id) VALUES (@Nev, @Kozet_id)";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);
                cmd.CommandText = query;

                cmd.Parameters.Add(new MySqlParameter("@Nev", MySqlDbType.VarChar));
                cmd.Parameters["@Nev"].Value = this.Nev;

                cmd.Parameters.Add(new MySqlParameter("@Kozet_id", MySqlDbType.Int32));
                cmd.Parameters["@Kozet_id"].Value = this.Kozet_id;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }

        public override void DeleteItself()
        {
            string query = "DELETE FROM tarnak WHERE id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(query))
            {

                cmd.Parameters.Add("@id", MySqlDbType.Int32);
                cmd.Parameters["@Id"].Value = this.Id;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public override void UpdateItself()
        {
            string query = "UPDATE tarnak set nev = @Nev, kozet_id = @Kozet_id WHERE id = @Id";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);
                cmd.CommandText = query;

                cmd.Parameters.Add(new MySqlParameter("@Id", MySqlDbType.VarChar));
                cmd.Parameters["@Id"].Value = this.Id;

                cmd.Parameters.Add(new MySqlParameter("@Nev", MySqlDbType.VarChar));
                cmd.Parameters["@Nev"].Value = this.Nev;

                cmd.Parameters.Add(new MySqlParameter("@Kozet_id", MySqlDbType.VarChar));
                cmd.Parameters["@Kozet_id"].Value = this.Kozet_id;


                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }


        //static read
        public static Tarna GetById(int id)
        {
            string query = "SELECT * from tarna WHERE id = @Id";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);
                cmd.CommandText = query;

                cmd.Parameters.Add(new MySqlParameter("@Id", MySqlDbType.VarChar));
                cmd.Parameters["@Id"].Value = id;

                using (DataTable queryTable = new DataTable())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(queryTable);
                    }

                    if (queryTable != null && queryTable.Rows.Count > 0)
                    {
                        return new Tarna(queryTable.Rows[0]);
                    }

                    return null;
                }
            }
        }

        public static List<Tarna> GetAll()
        {
            string query = "SELECT * from tarnak";

            List<Tarna> tarnak = new List<Tarna>();

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
                            tarnak.Add(new Tarna(row));
                        }

                        return tarnak;
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
