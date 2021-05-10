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
    }
}
