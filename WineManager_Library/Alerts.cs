using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineManager;

namespace WineManager
{
    public class Alerts
    {

        protected string name;
        protected string message;
        protected string linkedBottles;

        public Alerts(string name, string message, string bottles)
        {
            this.name = name;
            this.message = message;
            this.linkedBottles = bottles;
        }
        static public List<Alerts> ShowAllAlerts()
        {
            DBRequest req = new DBRequest();
            List<Alerts> lstAlert = req.GetAllAlerts();
            return lstAlert;
        }

        static public bool AddAlert(string alert, string message)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.AddAlert(alert, message);

            return res;

        }


        static public bool DelAlert(string alert)
        {
            bool res = false;
            DBRequest req = new DBRequest();

           res = req.DelAlert(alert);

            return res;

        }


        //all getter, to permit the application to view the data
        public string Name { get { return name; } }
        public string Message { get { return message; } }
        public string LinkedBottles { get { return linkedBottles; } }
    }
}
