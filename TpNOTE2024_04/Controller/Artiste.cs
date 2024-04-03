using MySql.Data.MySqlClient;
using System.Data;
using TpNOTE2024_04.Model;

namespace TpNOTE2024_04.Controllers
{
    public class Artiste
    {
        #region Attributs
        private DataTable? dtListeArtiste;
        private ConnexionBDD? conn;
        #endregion

        #region GetArtiste
        public DataTable GetListeArtiste(bool combo)
        {
            dtListeArtiste = new DataTable();
            conn = new ConnexionBDD();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDARTISTE,LABELARTISTE,GROUPEARTISTE FROM artiste ORDER BY LABELARTISTE;", conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeArtiste.Load(reader);
                   if (combo)
                    {
                        DataRow workRow = dtListeArtiste.NewRow();
                        workRow[0] = -1;
                        workRow[1] = "";
                        dtListeArtiste.Rows.InsertAt(workRow, 0);
                    }
                    

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.connection.Close();
            return dtListeArtiste;
        }

        public DataTable GetListeArtiste(bool combo, int IdArtiste)
        {
            dtListeArtiste = new DataTable();
            conn = new ConnexionBDD();
            string rqtSql = "SELECT IDARTISTE,LABELARTISTE,GROUPEARTISTE FROM artiste";
            if (IdArtiste > -1)
            {
                rqtSql += " WHERE IDARTISTE = " + IdArtiste;
            }           
            rqtSql += " ORDER BY LABELARTISTE;";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection))
                {
                    conn.connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeArtiste.Load(reader);
                    if (combo)
                    {
                        DataRow workRow = dtListeArtiste.NewRow();
                        workRow[0] = -1;
                        workRow[1] = "";
                        dtListeArtiste.Rows.InsertAt(workRow, 0);
                    }


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.connection.Close();
            return dtListeArtiste;
        }

        public String GetArtisteById(int idArtiste)
        {
            String difficultePartie = "";
            if (idArtiste > -1)
            {                            
                string rqtSql = "SELECT IDARTISTE,LABELARTISTE,GROUPEARTISTE FROM artiste WHERE IDARTISTE = " + idArtiste + ";";
                dtListeArtiste = new DataTable();
                conn = new ConnexionBDD();

                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection))
                    {
                        conn.connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        dtListeArtiste.Load(reader);                    

                    }
                    conn.connection.Close();
                    if (dtListeArtiste.Rows.Count > 0)
                    {
                        foreach (DataRow row in dtListeArtiste.Rows)
                        {
                            difficultePartie = row["LABELARTISTE"].ToString();
                        }
                    }                   
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }               
                
            }

            return difficultePartie;

        }
        #endregion

        #region InsertArtiste
        public void InsertArtiste(string labelArtiste, bool groupeArtiste)
        {
            conn = new ConnexionBDD();
            string rqtSql = "INSERT INTO artiste (LABELARTISTE,GROUPEARTISTE) VALUES (@labelA,@groupeA);";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection);

                cmd.Parameters.AddWithValue("@labelA", labelArtiste);
                cmd.Parameters.AddWithValue("@groupeA", groupeArtiste);
                conn.connection.Open();
                cmd.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.connection.Close();
        }
        #endregion

        #region UpdateArtiste
        public void UpdateArtiste(int idArtiste, string labelArtiste, bool groupeArtiste)
        {
            conn = new ConnexionBDD();
            string rqtSql = "UPDATE artiste SET LABELARTISTE = @labelA, GROUPEARTISTE = @groupeA WHERE IDARTISTE = @idA;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection);
                cmd.Parameters.AddWithValue("@labelA", labelArtiste);
                cmd.Parameters.AddWithValue("@groupeA", groupeArtiste);
                cmd.Parameters.AddWithValue("@idA", idArtiste);
                conn.connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            conn.connection.Close();
        }

        #endregion

        #region DeleteArtiste
        public bool DeleteArtiste(int idArtiste)
        {
            bool result = false;
            conn = new ConnexionBDD();
            string rqtSql = "DELETE FROM artiste WHERE IDARTISTE = @idA;";
            try
            {
                MySqlCommand cmd = new MySqlCommand(rqtSql, conn.connection);
                
                cmd.Parameters.AddWithValue("@idA", idArtiste);
                conn.connection.Open();
                cmd.ExecuteNonQuery();
                result = true;
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                result = false;
            }
            conn.connection.Close();
            return result;
        }

        #endregion
    }
}
