using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using WineManager;
using System.Linq;
using System.Threading.Tasks;

namespace WineManager
{
    public class DBRequest
    {
        //generating an instance of DBConnection, to enable the connection to the database
        DBConnection connDB = new DBConnection();
        DBConnection connDB2 = new DBConnection();

        public string GetVarietalByWineID(int id)
        {
            //List<string> lstVarietal = new List<string> { "test", "titi", "tat" };
            //TODO
            connDB2.OpenConnection();
            List<string> lstVarietal = new List<string>();
            string varietyName;
            int rowNumber;

            MySqlCommand cmdGetVarietal = connDB2.CreateQuery();
            cmdGetVarietal.CommandText = "SELECT grapeVarieties.varietyName " +
                "FROM " +
                "grapeVarieties " +
                "JOIN wines_has_grapeVarieties ON grapeVarieties.id = wines_has_grapeVarieties.grapeVariety_id " +
                "AND wines_has_grapeVarieties.wine_id = @wineID";

            cmdGetVarietal.Parameters.AddWithValue("@wineID", id);
            MySqlDataReader value = connDB.Select(cmdGetVarietal);
            
            value.Read();
            rowNumber = value.FieldCount;
            for(int x=0; x<rowNumber; x++)
            {
                varietyName = value[0].ToString();
                lstVarietal.Add(varietyName);
            }

            string combinedString = string.Join(", ", lstVarietal);
            connDB2.CloseConnection();
            return combinedString;
        }

        /**
         * SQL request to get a list of all bottles present in the database
         * return a list of object Bottles
         */
        public List<Bottles> GetAllBottles()
        {
            connDB.OpenConnection();
            //variable initializing
            int id =0;
            string name ="";
            string color = "";
            int number=0;
            double volume=0;
            string manufacturer = "";
            int year=0;
            string storage = "";
            string description = "";
            string strVarietal;
            List<Bottles> lstBot = new List<Bottles>();


            MySqlCommand cdmGetBottles = connDB.CreateQuery();

            cdmGetBottles.CommandText = "SELECT wines.id, wines.wineName, colors.wineColor, wines.bottleNumber, wines.volume, "+
                "manufacturers.manufacturersName, wines.productionYear, storageBoxes.name, wines.description " +
                "FROM " +
                "wines " +
                "LEFT JOIN colors ON wines.color_id = colors.id " +
                "LEFT JOIN manufacturers ON wines.manufacturer_id = manufacturers.id " +
                "LEFT JOIN storageBoxes ON wines.storagebox_id = storageBoxes.id ";

            MySqlDataReader value = connDB.Select(cdmGetBottles);

            //parsing the table created from the request
            while (value.Read())
            {
                //attributing the value from a certain position (value[]) to the correct variable
                name = value[1].ToString();
                bool res = int.TryParse(value[0].ToString(), out id);
                color = value[2].ToString();
                bool res2 = int.TryParse(value[3].ToString(), out number);
                bool res3 = double.TryParse(value[4].ToString(), out volume);
                manufacturer = value[5].ToString();
                bool res4 = int.TryParse(value[6].ToString(), out year);
                storage = value[7].ToString();
                description = value[8].ToString();
                
                //getting the varietal as a string 
                strVarietal = GetVarietalByWineID(id);

                //generate an object "Bottle", with the parameters from the database
                Bottles bot = new Bottles(name, color, number, volume, manufacturer, year, strVarietal, storage, description);
                //adding the object to the list of bottles
                lstBot.Add(bot);
            }
            connDB.CloseConnection();
            return lstBot;
        }
        
        /**
         * SQL request to get a list of all boxes present in the database
         * return a list of object Boxes
         */
        public List<StorageBoxes> GetAllBoxes()
        {
            connDB.OpenConnection();
            int id = 0;
            string name = "";
            string description = "";
            List<StorageBoxes> lstBox = new List<StorageBoxes>();


            MySqlCommand cmd = connDB.CreateQuery();

            cmd.CommandText = "SELECT id, name, location " +
                "FROM " +
                "storageBoxes ";

            MySqlDataReader value = connDB.Select(cmd);

            while (value.Read())
            {
                name = value[1].ToString();
                bool res = int.TryParse(value[0].ToString(), out id);
                description = value[2].ToString();

                StorageBoxes box = new StorageBoxes(name, description);
                lstBox.Add(box);
            }
            connDB.CloseConnection();
            return lstBox;
        }

        /**
         * SQL request to get a list of all alerts present in the database
         * return a list of object Alerts
         */
        public List<Alerts> GetAllAlerts()
        {
            connDB.OpenConnection();
            int id = 0;
            string name = "";
            string message = "";
            string associatedBottles;
            List<Alerts> lstAlert = new List<Alerts>();


            MySqlCommand cmd = connDB.CreateQuery();

            cmd.CommandText = "SELECT id, alertName, alertText " +
                "FROM " +
                "alerts ";

            MySqlDataReader value = connDB.Select(cmd);

            while (value.Read())
            {
                name = value[1].ToString();
                bool res = int.TryParse(value[0].ToString(), out id);
                message = value[2].ToString();

                //getting the varietal as a string 
                associatedBottles = GetAllBottlesWithAlert(id);

                //generate an object "Bottle", with the parameters from the database
                Alerts alert = new Alerts(name, message, associatedBottles);
                lstAlert.Add(alert);
            }
            connDB.CloseConnection();
            return lstAlert;
        }


        public string GetAllBottlesWithAlert(int id)
        {
            List<string> lstBottles = new List<string>();
            string bottleNames;

            MySqlCommand cmdGetBottles = connDB.CreateQuery();
            cmdGetBottles.CommandText = "SELECT wines.wineName" +
                    "FROM " +
                    "wines " +
                    "LEFT JOIN wines_has_alerts ON wines.id = wines_has_alerts.wine_id " +
                    "AND wines_has_alerts.alert_id = @alertID";
            cmdGetBottles.Parameters.AddWithValue("@alertID", id);

            MySqlDataReader value = connDB.Select(cmdGetBottles);

            while (value.Read())
            {
                bottleNames = value[1].ToString();
                lstBottles.Add(bottleNames);
            }

            //going from a list to a string
            string combinedString = string.Join(", ", lstBottles);
            return combinedString;
        }

}
}
