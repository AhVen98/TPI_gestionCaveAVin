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
        protected List<string> varietal;
        protected string storage;

        public Bottles(string name, string color, int number, double volume, string manufacturer, int year, List<string> varietal, string storage)
        {
            this.name = name;
            this.color = color;
            this.bottleNumber = number;
            this.volume = volume;
            this.manufacturer = manufacturer;
            this.year = year;
            this.varietal = varietal;
            this.storage = storage;
        }

        //all getter, to permit the application to view the data
        public string Name { get { return name; } }
        public string Color { get { return color; } }
        public int BottleNumber { get { return bottleNumber; } }
        public double Volume { get { return volume; } }
        public string Manufacturer { get { return manufacturer; } }
        public int Year{ get { return year; } }
        public List<string> Varietal { get { return varietal; } }
        public string Storage { get { return storage; } }

    }
}
