using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineManager
{
    public class Logs
    {
        protected string action;
        protected DateTime exactTime;
        protected string bottle;
        protected string alert;
        protected string box;


        public Logs(string name, DateTime exactTime, string bottle ="", string alert = "", string box = "")
        {
            this.action = name;
            this.exactTime = exactTime;
            this.bottle = bottle;
            this.alert = alert;
            this.box = box;
        }

        static public List<Alerts> ShowAllAlerts()
        {
            DBRequest req = new DBRequest();
            List<Alerts> lstalert = req.GetAllAlerts();
            return lstalert;
        }

        //all getter, to permit the application to view the data
        public string Name { get { return action; } }
        public DateTime ExactTime { get { return exactTime; } }
        public string Bottle { get { return bottle; } }
        public string Alert { get { return alert; } }
        public string Box { get { return box; } }
    }
}
