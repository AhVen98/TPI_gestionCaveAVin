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
        DBConnection connDB = new DBConnection();


        //exemple -> will be deleted once a correct request exist
        public void ReqReturnObject(int objectNumber)
        {
            connDB.OpenConnection();

            MySqlCommand cmd = connDB.CreateQuery();

            cmd.CommandText = "UPDATE locations SET effectiveReturnDate= @today WHERE locations.object_id =@objID";

            cmd.Parameters.AddWithValue("@objID", objectNumber);
            cmd.Parameters.AddWithValue("@today", DateTime.Today);

            connDB.ExecuteQuery(cmd);
            connDB.CloseConnection();
        }
        public string GetVarietalByWineID(int id)
        {
            List<string> lstVarietal = new List<string> { "test", "titi", "tat" };
           /** List<string> lstVarietal = new List<string>();
            string varietyName;

            MySqlCommand cdmGetVarietal = connDB.CreateQuery();
            cdmGetVarietal.CommandText = "SELECT wines.wineName, grapeVarieties.varietyName " +
                "FROM " +
                "wines " +
                "LEFT JOIN wines_has_grapeVarieties ON wines.id = wines_has_grapeVarieties.wine_id " +
                "LEFT JOIN grapeVarieties ON wines_has_grapeVarieties.wine_id= grapeVarieties.id ";

            MySqlDataReader value = connDB.Select(cdmGetVarietal);

            while (value.Read())
            {
                varietyName = value[1].ToString();
                lstVarietal.Add(varietyName);
            }**/

            string combinedString = string.Join(", ", lstVarietal);
            return combinedString;
        }


        public List<Bottles> GetAllBottles()
        {
            connDB.OpenConnection();
            int id =0;
            string name ="";
            string color = "";
            int number=0;
            double volume=0;
            string manufacturer = "";
            int year=0;
            string storage = "";
            string description = "";
            List<Bottles> lstBot = new List<Bottles>();
            List<string> varietal = new List<string>();
            string strVarietal;

            MySqlCommand cdmGetBottles = connDB.CreateQuery();

            cdmGetBottles.CommandText = "SELECT wines.id, wines.wineName, colors.wineColor, wines.bottleNumber, wines.volume, "+
                "manufacturers.manufacturersName, wines.productionYear, storageBoxes.name, wines.description " +
                "FROM " +
                "wines " +
                "LEFT JOIN colors ON wines.color_id = colors.id " +
                "LEFT JOIN manufacturers ON wines.manufacturer_id = manufacturers.id " +
                "LEFT JOIN storageBoxes ON wines.storagebox_id = storageBoxes.id ";

            MySqlDataReader value = connDB.Select(cdmGetBottles);

            while (value.Read())
            {
                name = value[1].ToString();
                bool res = int.TryParse(value[0].ToString(), out id);
                color = value[2].ToString();
                bool res2 = int.TryParse(value[3].ToString(), out number);
                bool res3 = double.TryParse(value[4].ToString(), out volume);
                manufacturer = value[5].ToString();
                bool res4 = int.TryParse(value[6].ToString(), out year);
                storage = value[7].ToString();
                description = value[8].ToString();
                //boucle to add 1 by 1 all varietal
                //foreach(string variety in GetVarietalByWineID(id))
                {
                    varietal.Add(GetVarietalByWineID(id));
                    strVarietal = string.Join(", ", varietal);
                }

                Bottles bot = new Bottles(name, color, number, volume, manufacturer, year, strVarietal, storage, description);
                lstBot.Add(bot);
            }
            connDB.CloseConnection();
            return lstBot;
        }

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

    }
}
