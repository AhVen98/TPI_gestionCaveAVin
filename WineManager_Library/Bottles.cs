using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineManager;

namespace WineManager
{
    public class Bottles
    {
        protected string name;
        protected string color;
        protected int bottleNumber;
        protected double volume;
        protected string manufacturer;
        protected int year;
        protected string varietal;
        protected string storage;
        protected string description;

        public Bottles(string name, string color, int number, double volume, string manufacturer, int year, string varietal, string storage, string description)
        {
            this.name = name;
            this.color = color;
            this.bottleNumber = number;
            this.volume = volume;
            this.manufacturer = manufacturer;
            this.year = year;
            this.varietal = varietal;
            this.storage = storage;
            this.description = description;
        }


        public Bottles(string name, double volume, int year)
        {
            this.name = name;
            this.volume = volume;
            this.year = year;
        }


        public Bottles()
        {
        }


        static public List<Bottles> ShowAllBottles()
        {
            DBRequest req = new DBRequest();
            List<Bottles> lstBot = req.GetAllBottles();
            return lstBot;
        }


        static public bool AddBottleWithDescAndVarietal(string name, string col, int num, double vol, string manu, int year, string box, List<string> var, string desc)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.AddBottleWDescAndVar(name, col, num, vol, manu, year, box, var, desc);

            return res;
        }


        static public bool AddBottleWithVarietal(string name, string col, int num, double vol, string manu, int year, string box, List<string> var)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.AddBottleWVar(name, col, num, vol, manu, year, box, var);

            return res;
        }


        static public bool AddBottleWithDesc(string name, string col, int num, double vol, string manu, int year, string box, string desc)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.AddBottleWDesc(name, col, num, vol, manu, year, box, desc);

            return res;
        }

        static public bool AddBottle(string name, string col, int num, double vol, string manu, int year, string box)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.AddBottle(name, col, num, vol, manu, year, box);

            return res;
        }

        static public bool AddAlertToBottle(string name, string alert)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.AddAlertToBottle(name,alert);

            return res;
        }

        static public bool RemoveBottle(string name, int num, double vol, string manu, int year)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.RemoveBottle(name, num, vol, manu, year);

            return res;
        }

        static public List<Bottles> ResearchByKeyword(string key)
        {
            List<Bottles> lstBot = new List<Bottles>();
            DBRequest req = new DBRequest();

            lstBot = req.ResearchByKeyword(key);

            return lstBot;
        }

        static public List<Bottles> OrderByColor()
        {
            List<Bottles> lstBot = new List<Bottles>();
            DBRequest req = new DBRequest();

            lstBot = req.OrderByColor();

            return lstBot;
        }

        static public List<Bottles> OrderByManufacturer()
        {
            List<Bottles> lstBot = new List<Bottles>();
            DBRequest req = new DBRequest();

            lstBot = req.OrderByManufacturer();

            return lstBot;
        }

        static public List<Bottles> OrderByCountry()
        {
            List<Bottles> lstBot = new List<Bottles>();
            DBRequest req = new DBRequest();

            lstBot = req.OrderByCountry();

            return lstBot;
        }

        static public List<Bottles> OrderByVarietal()
        {
            List<Bottles> lstBot = new List<Bottles>();
            DBRequest req = new DBRequest();

            lstBot = req.OrderByVarietal();

            return lstBot;
        }


        static public bool UpdateBottle(string wineName, int number, double volume, int year)
        {
            DBRequest req = new DBRequest();

            bool res = req.UpdateBottle(wineName, number, volume, year);

            return res;
        }


        static public List<Bottles> GetBottlesWithAlert(int id)
        {
            DBRequest req = new DBRequest();
            List<Bottles> lstBot = req.GetBottlesWithAlert(id);
            return lstBot;
        }


        static public Bottles GetBottleWithName(string name)
        {
            DBRequest req = new DBRequest();
            Bottles bot = req.GetBottleWithName(name);
            return bot;
        }


        //all getter, to permit other classes to view the data
        public string Name { get { return name; } }
        public string Color { get { return color; } }
        public int BottleNumber { get { return bottleNumber; } }
        public double Volume { get { return volume; } }
        public string Manufacturer { get { return manufacturer; } }
        public int Year{ get { return year; } }
        public string Varietal { get { return varietal; } }
        public string Storage { get { return storage; } }
        public string Description { get { return description; } }
        
    }
}
