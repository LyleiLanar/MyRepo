using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Teszt.Entities;

namespace Teszt
{
    public class Torpe : Entity
    {
        //props
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Klan { get; set; }
        public string Nem { get; set; }
        public int Suly { get; set; }
        public int Magassag { get; set; }

   
        //db constructor
        public Torpe(DataRow dataRow)
        {
            Id = Convert.ToInt32(dataRow[0]);
            Nev = Convert.ToString(dataRow[1]);
            Klan = Convert.ToString(dataRow[2]);
            Nem = Convert.ToString(dataRow[3]);
            Suly = Convert.ToInt32(dataRow[4]);
            Magassag = Convert.ToInt32(dataRow[5]);
        }

        //model constructor
        public Torpe(string nev, string klan, string nem, int suly, int magassag)
        {
            Nev = nev;
            Klan = klan;
            Nem = nem;
            Suly = suly;
            Magassag = magassag;
        }

        //CDU
        public override void CreateItself()
        {
            string query = "INSERT INTO torpek (nev, klan, nem, suly, magassag) VALUES (@Nev, @Klan, @Nem, @Suly, @Magassag)";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);
                cmd.CommandText = query;

                cmd.Parameters.Add(new MySqlParameter("@Nev", MySqlDbType.VarChar));
                cmd.Parameters["@Nev"].Value = this.Nev;

                cmd.Parameters.Add(new MySqlParameter("@Klan", MySqlDbType.VarChar));
                cmd.Parameters["@Klan"].Value = this.Klan;

                cmd.Parameters.Add(new MySqlParameter("@Nem", MySqlDbType.VarChar));
                cmd.Parameters["@Nem"].Value = this.Nem;

                cmd.Parameters.Add(new MySqlParameter("@Suly", MySqlDbType.Int32));
                cmd.Parameters["@Suly"].Value = this.Suly;


                cmd.Parameters.Add(new MySqlParameter("@Magassag", MySqlDbType.Int32));
                cmd.Parameters["@Magassag"].Value = this.Magassag;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }
        public override void DeleteItself()
        {
            string query = "DELETE FROM torpek WHERE id = @Id";

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

                cmd.Parameters.Add(new MySqlParameter("@Klan", MySqlDbType.VarChar));
                cmd.Parameters["@Klan"].Value = this.Klan;

                cmd.Parameters.Add(new MySqlParameter("@Nem", MySqlDbType.VarChar));
                cmd.Parameters["@Nem"].Value = this.Nem;

                cmd.Parameters.Add(new MySqlParameter("@Suly", MySqlDbType.Int32));
                cmd.Parameters["@Suly"].Value = this.Suly;

                cmd.Parameters.Add(new MySqlParameter("@Magassag", MySqlDbType.Int32));
                cmd.Parameters["@Magassag"].Value = this.Magassag;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }

        //static read
        public static Torpe GetById(int id)
        {
            string query = "SELECT * from torpek WHERE id = @Id";

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
                        return new Torpe(dataTable.Rows[0]);
                    }

                    return null;
                }
            }
        }

        public static List<Torpe> GetAll()
        {
            List<Torpe> torpek = new List<Torpe>();
            string query = "SELECT * from torpek";

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
                            torpek.Add(new Torpe(row));
                        }

                        return torpek;
                    }

                    return null;
                }
            }
        }

        public static List<Torpe> GetAllByNameFrag(string frag)
        {
            List<Torpe> torpek = new List<Torpe>();
            string query = $"SELECT * from torpek WHERE nev like @Frag;";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);

                cmd.Parameters.Add(new MySqlParameter("@Frag", MySqlDbType.VarChar));
                cmd.Parameters["@Frag"].Value = $"%{frag}%";

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
                            torpek.Add(new Torpe(row));
                        }

                        return torpek;
                    }

                    return null;
                }
            }
        }

        public DataTable GetKitermelesek()
        {

            string query = "SELECT tarnak.nev, kihol.kitermelt_mennyiseg FROM torpek" +
                " INNER JOIN kihol ON torpek.id = kihol.torpe_id" +
                " INNER JOIN tarnak ON kihol.tarna_id = tarnak.id" +
                " WHERE torpek.id = @TorpeId;";
            //string query = "SELECT * from kihol WHERE torpe_id = @TorpeId;";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                List<Kihol> kiholok = new List<Kihol>();

                cmd.CommandText = query;
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);

                cmd.Parameters.Add(new MySqlParameter("@TorpeId", MySqlDbType.Int32));
                cmd.Parameters["@TorpeId"].Value = this.Id;

                using (DataTable dataTable = new DataTable())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        //foreach (DataRow row in dataTable.Rows)
                        //{
                        //    kiholok.Add(new Kihol(row));
                        //}

                        return dataTable;
                    }

                    return null;
                }
            }
        }


        public override void Validation()
        {
            throw new System.NotImplementedException();
        }
    }
}
