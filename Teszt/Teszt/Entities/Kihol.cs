using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Teszt.Entities
{
    public class Kihol : Entity
    {
        public int TorpeId { get; set; }
        public int TarnaId { get; set; }
        public int KitermeltMennyiseg { get; set; }

        public Kihol(DataRow dataRow)
        {
            TorpeId = Convert.ToInt32(dataRow[0]);
            TarnaId = Convert.ToInt32(dataRow[1]);
            KitermeltMennyiseg = Convert.ToInt32(dataRow[2]);
        }

        public Kihol(int torpeId, int tarna_Id, int kitermeltMennyiseg)
        {
            TorpeId = torpeId;
            TarnaId = tarna_Id;
            KitermeltMennyiseg = kitermeltMennyiseg;
        }

        public override void CreateItself()
        {
            string query = "INSERT INTO kihol (torpe_id, tarna_id, kitermelt_mennyiseg) VALUES (@TorpeId, @TarnaId, @KitermeltMennyiseg)";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);
                cmd.CommandText = query;

                cmd.Parameters.Add(new MySqlParameter("@TorpeId", MySqlDbType.Int32));
                cmd.Parameters["@TorpeId"].Value = this.TorpeId;

                cmd.Parameters.Add(new MySqlParameter("@TarnaId", MySqlDbType.Int32));
                cmd.Parameters["@TarnaId"].Value = this.TarnaId;

                cmd.Parameters.Add(new MySqlParameter("@KitermeltMennyiseg", MySqlDbType.Int32));
                cmd.Parameters["@KitermeltMennyiseg"].Value = this.KitermeltMennyiseg;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }

        public override void DeleteItself()
        {
            string query = "DELETE FROM kihol WHERE torpe_id = @TorpeId AND tarna_id = @TarnaId";

            using (MySqlCommand cmd = new MySqlCommand(query))
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);

                cmd.Parameters.Add("@TorpeId", MySqlDbType.Int32);
                cmd.Parameters["@TorpeId"].Value = this.TorpeId;

                cmd.Parameters.Add("@TarnaId", MySqlDbType.Int32);
                cmd.Parameters["@TarnaId"].Value = this.TarnaId;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();
            }
        }

        public override void UpdateItself()
        {
            string query = "UPDATE kihol set torpe_id = @TorpeId, tarna_id = @TarnaId, kitermelt_mennyiseg = @KitermeltMennyiseg WHERE torpe_id = @TorpeId AND tarna_id = @TarnaId";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);
                cmd.CommandText = query;

                cmd.Parameters.Add(new MySqlParameter("@TorpeId", MySqlDbType.Int32));
                cmd.Parameters["@TorpeId"].Value = this.TorpeId;

                cmd.Parameters.Add(new MySqlParameter("@TarnaId", MySqlDbType.Int32));
                cmd.Parameters["@TarnaId"].Value = this.TarnaId;

                cmd.Parameters.Add(new MySqlParameter("@KitermeltMennyiseg", MySqlDbType.Int32));
                cmd.Parameters["@KitermeltMennyiseg"].Value = this.KitermeltMennyiseg;

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

            }
        }


        //static read
        public static Kihol GetByIds(int torpId, int tarnaId)
        {
            string query = "SELECT * from kihol WHERE torpe_id = @TorpId AND tarna_id = @TarnaId";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = query;
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);

                cmd.Parameters.Add(new MySqlParameter("@TorpId", MySqlDbType.VarChar));
                cmd.Parameters["@TorpId"].Value = torpId;

                cmd.Parameters.Add(new MySqlParameter("@TarnaId", MySqlDbType.VarChar));
                cmd.Parameters["@TarnaId"].Value = tarnaId;

                using (DataTable dataTable = new DataTable())
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        return new Kihol(dataTable.Rows[0]);
                    }

                    return null;
                }
            }
        }

        public static List<Kihol> GetAll()
        {
            string query = "SELECT * from kihol;";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                List<Kihol> kiholok = new List<Kihol>();

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
                            kiholok.Add(new Kihol(row));
                        }

                        return kiholok;
                    }

                    return null;
                }
            }
        }

        public static List<Kihol> GetAllByTorpeId(int torpeId)
        {
            string query = "SELECT * from kihol WHERE torpe_id = @TorpeId;";

            using (MySqlCommand cmd = new MySqlCommand())
            {
                List<Kihol> kiholok = new List<Kihol>();

                cmd.CommandText = query;
                cmd.Connection = new MySqlConnection(ConnectionStringHelper.DefaultConnectionString);

                cmd.Parameters.Add(new MySqlParameter("@TorpeId", MySqlDbType.Int32));
                cmd.Parameters["@TorpeId"].Value = torpeId;

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
                            kiholok.Add(new Kihol(row));
                        }

                        return kiholok;
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
