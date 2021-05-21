﻿using System;
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
        protected string element;


        public Logs(string name, DateTime exactTime, string element)
        {
            this.action = name;
            this.exactTime = exactTime;
            this.element = element;
        }

        static public List<Logs> GetAllLogs()
        {
            DBRequest req = new DBRequest();
            List<Logs> lstlog = req.GetAllLogs();
            return lstlog;
        }

        static public void AddLog(string action, int bottleID)
        {
            DateTime moment = DateTime.Now;
            DBRequest req = new DBRequest();


            switch (action)
            {
                case "ajoutNouvelle":
                    req.LogAddNew(bottleID);
                    break;
                case "ajoutExistante":
                    req.LogAddExist(bottleID);
                    break;
                case "retrait":
                    req.LogDel(bottleID);
                    break;
                case "default":
                    break;
            }
        }

        //all getter, to permit the application to view the data
        public string Action { get { return action; } }
        public DateTime ExactTime { get { return exactTime; } }
        public string Element { get { return element; } }
    }
}
