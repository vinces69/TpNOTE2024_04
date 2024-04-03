using MySql.Data.MySqlClient;


namespace TpNOTE2024_04.Model
{
    public class ConnexionBDD
    {
        #region Attributs
        string server ="";
        string database="";
        string uid = "";
        string password="";
        public MySqlConnection connection;
        #endregion

        #region Constructeur
        public ConnexionBDD()
        {
            Initialise();
        }
        #endregion

        #region ouverture de la connexion avec Mysql
        private void Initialise()
        {
            server = "localhost";
            database = "bdd_musiquev2";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        #endregion
    }
}
