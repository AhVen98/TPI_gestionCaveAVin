using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineManager;


namespace WineManager
{
    public class DBConnection
    {
        private MySqlConnection connection;

        // Constructeur
        public DBConnection()
        {
            InitConnexion();
        }

        // Method to initialize connection
        private void InitConnexion()
        {
            // Création de la chaîne de connexion

            string connectionString = "SERVER=127.0.0.1; DATABASE=wineManager; UID=root; PASSWORD=root";
            connection = new MySqlConnection(connectionString);
        }

        // Method to open the connection to database
        public void OpenConnection()
        {
            connection.Open();
        }

        // Method to initialise the variable for the query
        public MySqlCommand CreateQuery()
        {
            return connection.CreateCommand();
        }

        // Method to execute the query received in parameter
        public void ExecuteQuery(MySqlCommand command)
        {
            command.ExecuteNonQuery();
        }

        public bool ExecuteQueryWCheck(MySqlCommand command)
        {
            int nb = command.ExecuteNonQuery();
            // check if the query has an impact on DB
            if(nb>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        // Method used in other to read the content of a select in database
        public MySqlDataReader Select(MySqlCommand command)
        {
            return command.ExecuteReader();
        }


        // Method to close the connection to database
        public void CloseConnection()
        {
            connection.Close();
        }
    }
}
