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

        /**
         * SQL request to get a list of all varietals corresponding to the given wineID
         * return a string of concatenated varietalID
         */
        public string GetVarietalByWineID(int id)
        {
            connDB2.OpenConnection();
            List<string> lstVarietal = new List<string>();
            string varietyName;

            MySqlCommand cmdGetVarietal = connDB2.CreateQuery();
            cmdGetVarietal.CommandText = "SELECT grapeVarieties.varietyName " +
                "FROM " +
                "grapeVarieties " +
                "JOIN wines_has_grapeVarieties ON grapeVarieties.id = wines_has_grapeVarieties.grapeVariety_id " +
                "AND wines_has_grapeVarieties.wine_id = @wineID";

            cmdGetVarietal.Parameters.AddWithValue("@wineID", id);
            MySqlDataReader value = connDB.Select(cmdGetVarietal);

            while (value.Read())
            {
                for (int x = 0; x < value.FieldCount; x++)
                {
                    varietyName = value[0].ToString();
                    lstVarietal.Add(varietyName);
                }

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


        /**
        * SQL request to get a list of all manufacturers present in the database
        * return a list of string
        * used for the dropdown field in the bottlesmanagement
        */
        public List<string> GetListManufacturers()
        {
            connDB.OpenConnection();

            List<string> lstManu = new List<string>();
            MySqlCommand cmdGetManufacturers= connDB.CreateQuery();

            cmdGetManufacturers.CommandText = "SELECT distinct manufacturersName FROM manufacturers ORDER BY manufacturersName ASC";


            MySqlDataReader value = connDB.Select(cmdGetManufacturers);

            while (value.Read())
            {
                for (int i = 0; i < value.FieldCount; i++)
                {
                    lstManu.Add(value.GetString(i));
                }
            }

            connDB.CloseConnection();
            return lstManu;
        }


        /**
        * SQL request to get a list of all wine's colors present in the database
        * return a list of string
        * used for the dropdown field in the bottlesmanagement
        */
        public List<string> GetListColors()
        {
            connDB.OpenConnection();

            List<string> lstCol = new List<string>();
            MySqlCommand cmdGetColors = connDB.CreateQuery();

            cmdGetColors.CommandText = "SELECT distinct wineColor FROM colors ORDER BY wineColor ASC";


            MySqlDataReader value = connDB.Select(cmdGetColors);

            while (value.Read())
            {
                for (int i = 0; i < value.FieldCount; i++)
                {
                    lstCol.Add(value.GetString(i));
                }
            }

            connDB.CloseConnection();
            return lstCol;
        }


        /**
        * SQL request to get a list of all wine's colors present in the database
        * return a list of string
        * used for the dropdown field in the bottlesmanagement
        */
        public List<string> GetListVarieties()
        {
            connDB.OpenConnection();

            List<string> lstVar = new List<string>();
            MySqlCommand cmdGetVarieties = connDB.CreateQuery();

            cmdGetVarieties.CommandText = "SELECT DISTINCT varietyName FROM grapeVarieties ORDER BY varietyName ASC";


            MySqlDataReader value = connDB.Select(cmdGetVarieties);

            while (value.Read())
            {
                for (int i = 0; i < value.FieldCount; i++)
                {
                    lstVar.Add(value.GetString(i));
                }
            }

            connDB.CloseConnection();
            return lstVar;
        }


        /**
        * SQL request to get a list of all wine's colors present in the database
        * return a list of string
        * used for the dropdown field in the bottlesmanagement
        */
        public List<string> GetListStorages()
        {
            connDB.OpenConnection();

            List<string> lstStor = new List<string>();
            MySqlCommand cmdGetStorage = connDB.CreateQuery();

            cmdGetStorage.CommandText = "SELECT name FROM storageBoxes";


            MySqlDataReader value = connDB.Select(cmdGetStorage);

            while (value.Read())
            {
                for (int i = 0; i < value.FieldCount; i++)
                {
                    lstStor.Add(value.GetString(i));
                }
            }

            connDB.CloseConnection();
            return lstStor;
        }


        /**
        * SQL request to get a list of all productionyears present in the database
        * return a list of int
        * used for the dropdown field in the bottlesmanagement
        */
        public List<int> GetListDistinctYears()
        {
            connDB.OpenConnection();

            List<int> lstYear = new List<int>();
            MySqlCommand cmdGetYears = connDB.CreateQuery();

            cmdGetYears.CommandText = "SELECT DISTINCT productionYear FROM wines ORDER BY productionYear ASC";


            MySqlDataReader value = connDB.Select(cmdGetYears);

            while (value.Read())
            {
                int temp;
                for (int i = 0; i < value.FieldCount; i++)
                {
                    bool res = int.TryParse(value[0].ToString(), out temp);
                    lstYear.Add(temp);
                }
            }

            connDB.CloseConnection();
            return lstYear;
        }


        /**
        * SQL request to get a list of all wines present in the database
        * return a list of string
        * used for the dropdown field in the bottlesmanagement
        */
        public List<string> GetListWines()
        {
            connDB.OpenConnection();

            List<string> lstWin = new List<string>();
            MySqlCommand cmdGetWines = connDB.CreateQuery();

            cmdGetWines.CommandText = "SELECT DISTINCT wineName FROM wines ORDER BY wineName ASC";

            MySqlDataReader value = connDB.Select(cmdGetWines);

            while (value.Read())
            {
                for (int i = 0; i < value.FieldCount; i++)
                {
                    lstWin.Add(value.GetString(i));
                }
            }

            connDB.CloseConnection();
            return lstWin;
        }


        /**
         * request to check if the bottle with the same parameter already exists
         */
        public bool CheckBottlePresence(string name, int year, double volume)
        {
            bool presence = false;

            return presence;
        }

        /**
         * request to add a bottle with no description and no varietal
         * return a boolean, to check if it has been done correctly
         */
        public bool AddBottle(string name, string col, int num, double vol, string manu, int year, string box)
        {
            bool res = false;
            // getting the needed ID from the name
            int colorID;
            int manufacturerID;
            int storageID;

            colorID = GetIDColorByName(col);
            manufacturerID = GetIDManuByName(manu);
            storageID = GetIDStorageByName(box);

            MySqlCommand cmd = connDB.CreateQuery();

            connDB.OpenConnection();
   
            cmd.CommandText = "INSERT INTO wines "+
                "(wineName, productionYear, bottleNumber, volume, color_id, manufacturer_id, storagebox_id) "+
                "VALUES " +
                "(@name,  @year, @number, @volume, @colID, @manuID, @storID)";
            // link to all parameters needed in the request
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@number", num);
            cmd.Parameters.AddWithValue("@volume", vol);
            cmd.Parameters.AddWithValue("@colID", colorID);
            cmd.Parameters.AddWithValue("@manuID", manufacturerID);
            cmd.Parameters.AddWithValue("@storID", storageID);

            res = connDB.ExecuteQueryWCheck(cmd);
            connDB.CloseConnection();

            return res;
        }


        /**
         * request to add a bottle with a description and no varietal
         * return a boolean, to check if it has been done correctly
         */
        public bool AddBottleWDesc(string name, string col, int num, double vol, string manu, int year, string box, string desc)
        {
            bool res = false;
            // getting the needed ID from the name
            int colorID;
            int manufacturerID;
            int storageID;

            colorID = GetIDColorByName(col);
            manufacturerID = GetIDManuByName(manu);
            storageID = GetIDStorageByName(box);

            MySqlCommand cmd = connDB.CreateQuery();

            connDB.OpenConnection();

            cmd.CommandText = "INSERT INTO wines " +
                "(wineName, productionYear, bottleNumber, volume, color_id, manufacturer_id, storagebox_id, description) " +
                "VALUES " +
                "(@name,  @year, @number, @volume, @colID, @manuID, @storID, @desc)";
            // link to all parameters needed in the request
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@number", num);
            cmd.Parameters.AddWithValue("@volume", vol);
            cmd.Parameters.AddWithValue("@colID", colorID);
            cmd.Parameters.AddWithValue("@manuID", manufacturerID);
            cmd.Parameters.AddWithValue("@storID", storageID);
            cmd.Parameters.AddWithValue("@desc", desc);

            res = connDB.ExecuteQueryWCheck(cmd);

            connDB.CloseConnection();

            return res;
        }


        /**
         * request to add a bottle with no description and one or more varietal
         * return a boolean, to check if it has been done correctly
         */
        public bool AddBottleWVar(string name, string col, int num, double vol, string manu, int year, string box, List<string> var)
        {
            bool res = false;
            // getting the needed ID from the name
            int colorID;
            int manufacturerID;
            int storageID;
            int wineID;

            colorID = GetIDColorByName(col);
            manufacturerID = GetIDManuByName(manu);
            storageID = GetIDStorageByName(box);

            MySqlCommand cmd = connDB.CreateQuery();

            connDB.OpenConnection();

            cmd.CommandText = "INSERT INTO wines " +
                "(wineName, productionYear, bottleNumber, volume, color_id, manufacturer_id, storagebox_id) " +
                "VALUES " +
                "(@name,  @year, @number, @volume, @colID, @manuID, @storID)";
            // link to all parameters needed in the request
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@number", num);
            cmd.Parameters.AddWithValue("@volume", vol);
            cmd.Parameters.AddWithValue("@colID", colorID);
            cmd.Parameters.AddWithValue("@manuID", manufacturerID);
            cmd.Parameters.AddWithValue("@storID", storageID);

            res = connDB.ExecuteQueryWCheck(cmd);

            // to be able to add the varietal to the intermediate table, the id from the wine is needed. It's the last one added
            wineID = GetIDLastWineAdded();

            connDB.CloseConnection();
            // adding the varietals to the intermediate table
            foreach(string varietal in var)
            {
                int varID = GetIDVarByName(varietal);
                res = AddVarietalAndWine(varID, wineID);
            }

            return res;
        }


        /**
         * request to add a bottle with a description and one or more varietal
         * return a boolean, to check if it has been done correctly
         */
        public bool AddBottleWDescAndVar(string name, string col, int num, double vol, string manu, int year, string box, List<string> var, string desc)
        {
            bool res = false;
            // getting the needed ID from the name
            int colorID;
            int manufacturerID;
            int storageID;
            int wineID;

            colorID = GetIDColorByName(col);
            manufacturerID = GetIDManuByName(manu);
            storageID = GetIDStorageByName(box);

            MySqlCommand cmd = connDB.CreateQuery();

            connDB.OpenConnection();

            cmd.CommandText = "INSERT INTO wines " +
                "(wineName, productionYear, bottleNumber, volume, color_id, manufacturer_id, storagebox_id, description) " +
                "VALUES " +
                "(@name,  @year, @number, @volume, @colID, @manuID, @storID, @desc)";
            // link to all parameters needed in the request
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@year", year);
            cmd.Parameters.AddWithValue("@number", num);
            cmd.Parameters.AddWithValue("@volume", vol);
            cmd.Parameters.AddWithValue("@colID", colorID);
            cmd.Parameters.AddWithValue("@manuID", manufacturerID);
            cmd.Parameters.AddWithValue("@storID", storageID);
            cmd.Parameters.AddWithValue("@desc", desc);

            res = connDB.ExecuteQueryWCheck(cmd);

            // to be able to add the varietal to the intermediate table, the id from the wine is needed. It's the last one added
            wineID = GetIDLastWineAdded();

            connDB.CloseConnection();
            // adding the varietals to the intermediate table
            foreach (string varietal in var)
            {
                int varID = GetIDVarByName(varietal);
                res = AddVarietalAndWine(varID, wineID);
            }

            return res;
        }


        /**
         * request to get the corresponding ID for the color with this name
         */
        public int GetIDColorByName(string name)
        {
            connDB2.OpenConnection();
            int ID = -1;

            MySqlCommand cmdGetID = connDB2.CreateQuery();
            cmdGetID.CommandText = "SELECT colors.id " +
                "FROM " +
                "colors " +
                "WHERE colors.wineColor = @col";

            cmdGetID.Parameters.AddWithValue("@col", name);
            MySqlDataReader value = connDB.Select(cmdGetID);

            while (value.Read())
            {
               int.TryParse(value[0].ToString(), out ID);
            }

            connDB2.CloseConnection();
            return ID;
        }


        /**
         * request to get the corresponding ID for the manufacturer with this name
         */
        public int GetIDManuByName(string manu)
        {
            connDB2.OpenConnection();
            int ID = -1;

            MySqlCommand cmdGetID = connDB2.CreateQuery();
            cmdGetID.CommandText = "SELECT manufacturers.id " +
                "FROM " +
                "manufacturers " +
                "WHERE manufacturers.manufacturersName = @manu";

            cmdGetID.Parameters.AddWithValue("@manu", manu);
            MySqlDataReader value = connDB.Select(cmdGetID);

            while (value.Read())
            {
                int.TryParse(value[0].ToString(), out ID);
            }

            connDB2.CloseConnection();
            return ID;
        }


        /**
         * request to get the corresponding ID for the storage with this name
         */
        public int GetIDStorageByName(string storage)
        {
            connDB2.OpenConnection();
            int ID = -1;

            MySqlCommand cmdGetID = connDB2.CreateQuery();
            cmdGetID.CommandText = "SELECT storageBoxes.id " +
                "FROM " +
                "storageBoxes " +
                "WHERE storageBoxes.name = @box";

            cmdGetID.Parameters.AddWithValue("@box", storage);
            MySqlDataReader value = connDB.Select(cmdGetID);

            while (value.Read())
            {
                int.TryParse(value[0].ToString(), out ID);
            }

            connDB2.CloseConnection();
            return ID;
        }


        /**
         * request to get the last inserted ID in the wine table 
         * -> used to add varietal to intermediate table after that
         */
        public int GetIDLastWineAdded()
        {
            connDB2.OpenConnection();
            int ID = -1;

            MySqlCommand cmdGetID = connDB2.CreateQuery();
            cmdGetID.CommandText = "SELECT wines.id FROM wines "+
                "ORDER BY "+
                "id DESC "+
                "LIMIT 1";

            MySqlDataReader value = connDB.Select(cmdGetID);

            while (value.Read())
            {
                int.TryParse(value[0].ToString(), out ID);
            }

            connDB2.CloseConnection();
            return ID;
        }


        /**
        * request to get the corresponding ID for the varietal with this name
        */
        public int GetIDVarByName(string var)
        {
            connDB2.OpenConnection();
            int ID = -1;

            MySqlCommand cmdGetID = connDB2.CreateQuery();
            cmdGetID.CommandText = "SELECT grapeVarieties.id " +
                "FROM " +
                "grapeVarieties " +
                "WHERE grapeVarieties.varietyName = @var";

            cmdGetID.Parameters.AddWithValue("@var", var);
            MySqlDataReader value = connDB.Select(cmdGetID);

            while (value.Read())
            {
                int.TryParse(value[0].ToString(), out ID);
            }

            connDB2.CloseConnection();
            return ID;
        }

        /**
        * request to get the corresponding ID for the wine with this name, volume and production year
        */
        public int GetWineIDByNameVolYear(string name, double volume, int year)
        {
            connDB2.OpenConnection();
            int ID = -1;

            MySqlCommand cmdGetID = connDB2.CreateQuery();
            cmdGetID.CommandText = "SELECT wines.id " +
                "FROM " +
                "wines " +
                "WHERE wines.wineName = @name " +
                "AND wines.volume = @vol "+
                "AND wines.productionYear = @year";

            cmdGetID.Parameters.AddWithValue("@name", name);
            cmdGetID.Parameters.AddWithValue("@vol", volume);
            cmdGetID.Parameters.AddWithValue("@year", year);

            MySqlDataReader value = connDB.Select(cmdGetID);

            while (value.Read())
            {
                int.TryParse(value[0].ToString(), out ID);
            }

            connDB2.CloseConnection();
            return ID;
        }

        public int GetWineBottleNumberByID(int ID)
        {
            connDB2.OpenConnection();
            int nbBottle = -1;

            MySqlCommand cmdGetID = connDB2.CreateQuery();
            cmdGetID.CommandText = "SELECT wines.bottleNumber " +
                "FROM " +
                "wines " +
                "WHERE wines.id = @ID ";

            cmdGetID.Parameters.AddWithValue("@ID", ID);

            MySqlDataReader value = connDB.Select(cmdGetID);

            while (value.Read())
            {
                int.TryParse(value[0].ToString(), out nbBottle);
            }

            connDB2.CloseConnection();
            return nbBottle;
        }

        public bool AddVarietalAndWine(int var, int wine)
        {
            bool res = false;
           
            MySqlCommand cmd = connDB.CreateQuery();

            connDB.OpenConnection();

            cmd.CommandText = "INSERT INTO wines_has_grapeVarieties " +
                "(wine_id, grapeVariety_id) " +
                "VALUES " +
                "(@wine,  @var)";
            // link to all parameters needed in the request
            cmd.Parameters.AddWithValue("@wine", wine);
            cmd.Parameters.AddWithValue("@var", var);

            res = connDB.ExecuteQueryWCheck(cmd);

            connDB.CloseConnection();

            return res;
        }

        
        public bool RemoveBottle(string name, int number, double volume, string manufacturer, int year)
        {
            bool res = false;
            int wineID = GetWineIDByNameVolYear(name, volume, year);
            int bottleNumber = GetWineBottleNumberByID(wineID);
            int newNumber = bottleNumber - number;

            MySqlCommand cmd = connDB.CreateQuery();

            connDB.OpenConnection();

            cmd.CommandText = "UPDATE wines " +
                "SET "+
                "bottleNumber = @number "+
                "WHERE " +
                "wines.id = @wineID";
            // link to all parameters needed in the request
            cmd.Parameters.AddWithValue("@wineID", wineID);
            cmd.Parameters.AddWithValue("@number", newNumber);

            res = connDB.ExecuteQueryWCheck(cmd);

            connDB.CloseConnection();

            return res;
        }
    }
}
