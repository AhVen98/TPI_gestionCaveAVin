using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineManager;

namespace WineManager
{
    [TestClass()]
    public class BottlesTests
    {
        List<Bottles> lstBottles = new List<Bottles>();
        List<Bottles> lstKeyword = new List<Bottles>();
        List<Bottles> lstColor = new List<Bottles>();
        List<Bottles> lstManufacturer = new List<Bottles>();
        List<Bottles> lstCountry = new List<Bottles>();
        List<Bottles> lstVarietal = new List<Bottles>();
        List<Bottles> lstBottlesWithAlerts = new List<Bottles>();

        Bottles bottleByName = new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test");
        Bottles bottle3Params = new Bottles("bouteille3", 0.75, 1995);
        Bottles bottleToUpdate = new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test");
        Bottles bottleToAdd = new Bottles("bouteille4", "rouge", 5, 0.5, "producteur 1", 2015, "cépage1, cépage2", "casier1", "description Bouteille4");
        
        Alerts alert = new Alerts("alerte1", "message1", "bouteille1");

        [TestInitialize]
        public void Initialize()
        {
            lstBottles = new List<Bottles>() 
                { 
                    new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test"), 
                    new Bottles("bouteille2", "blanc", 6, 1.5, "producteur 3", 1960, "cépage2", "casier3", "description bouteille 2"), 
                    new Bottles("bouteille3", "rose", 1, 1.0, "producteur 1", 1999, "cépage1", "casier1", "description bouteille 3")
                };
            lstColor = new List<Bottles>()
                {
                    new Bottles("bouteille2", "blanc", 6, 1.5, "producteur 3", 1960, "cépage2", "casier3", "description bouteille 2"),
                    new Bottles("bouteille3", "rose", 1, 1.0, "producteur 1", 1999, "cépage1", "casier1", "description bouteille 3"),
                    new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test"),
                };
            lstManufacturer = new List<Bottles>()
                {
                    new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test"),
                    new Bottles("bouteille3", "rose", 1, 1.0, "producteur 1", 1999, "cépage1", "casier1", "description bouteille 3"),
                    new Bottles("bouteille2", "blanc", 6, 1.5, "producteur 3", 1960, "cépage2", "casier3", "description bouteille 2"),
                };
            lstCountry = new List<Bottles>()
                {
                    new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test"),
                    new Bottles("bouteille3", "rose", 1, 1.0, "producteur 1", 1999, "cépage1", "casier1", "description bouteille 3"),
                    new Bottles("bouteille2", "blanc", 6, 1.5, "producteur 3", 1960, "cépage2", "casier3", "description bouteille 2"),
                };
            lstKeyword = new List<Bottles>()
                {
                    new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test")
                };
            lstVarietal = new List<Bottles>()
                {
                    new Bottles("bouteille3", "rose", 1, 1.0, "producteur 1", 1999, "cépage1", "casier1", "description bouteille 3"),
                    new Bottles("bouteille2", "blanc", 6, 1.5, "producteur 3", 1960, "cépage2", "casier3", "description bouteille 2"),
                    new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test"),
                 };
            lstBottlesWithAlerts = new List<Bottles>()
                {
                    new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test"),
                };

            bottleByName = new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test");
            bottle3Params = new Bottles("bouteille3", 0.75, 1995);
            bottleToAdd = new Bottles("bouteille4", "rouge", 5, 0.5, "producteur 1", 2015, "cépage1, cépage2", "casier1", "description Bouteille4");
            bottleToUpdate = new Bottles("bouteille1", "rouge", 4, 1.0, "producteur 1", 2020, "cépage3", "casier2", "description test");
            
            alert = new Alerts("alerte1", "message1", "bouteille1");
        }

        [TestMethod]
        public void ShowAllBottles_NoSorting_OK()
        {
            List<Bottles> resExpected = lstBottles;
            List<Bottles> resCalculated = new List<Bottles>();

            resCalculated = Bottles.ShowAllBottles();

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void AddBottleWithDescAndVarietal_Allparams_OK()
        {
            bool resExpected = true;
            bool resCalculated;

            // resCalculated = Bottles.AddBottleWithDescAndVarietal(bottleToAdd.Name, bottleToAdd.Color, bottleToAdd.BottleNumber, bottleToAdd.Volume, bottleToAdd.Manufacturer, bottleToAdd.Year, bottleToAdd.Storage, bottleToAdd.Varietal, bottleToAdd.Description);

           // Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void AddAlertToBottle_Allparams_OK()
        {
            bool resExpected = true;
            bool resCalculated;

            resCalculated = Bottles.AddAlertToBottle(bottleToAdd.Name, alert.Name);

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void RemoveBottle_Allparams_OK()
        {
            bool resExpected = true;
            bool resCalculated;

            resCalculated = Bottles.RemoveBottle(bottleToAdd.Name, bottleToAdd.BottleNumber, bottleToAdd.Volume, bottleToAdd.Manufacturer, bottleToAdd.Year);

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void ResearchByKeyWord_existingword_OK()
        {
            List<Bottles> resExpected = lstKeyword;
            List<Bottles> resCalculated;

            resCalculated = Bottles.ResearchByKeyword("test");

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void OrderByColor_alphabetical_OK()
        {
            List<Bottles> resExpected = lstColor;
            List<Bottles> resCalculated;

            resCalculated = Bottles.OrderByColor();

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void OrderByManufacturer_alphabetical_OK()
        {
            List<Bottles> resExpected = lstManufacturer;
            List<Bottles> resCalculated;

            resCalculated = Bottles.OrderByManufacturer();

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void OrderByCountry_alphabetical_OK()
        {
            List<Bottles> resExpected = lstCountry;
            List<Bottles> resCalculated;

            resCalculated = Bottles.OrderByManufacturer();

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void OrderByVarietal_alphabetical_OK()
        {
            List<Bottles> resExpected = lstVarietal;
            List<Bottles> resCalculated;

            resCalculated = Bottles.OrderByVarietal();

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void UpdateBottle_Allparams_OK()
        {
            bool resExpected = true;
            bool resCalculated;

            resCalculated = Bottles.UpdateBottle(bottleToUpdate.Name, bottleToUpdate.BottleNumber, bottleToUpdate.Volume, bottleToUpdate.Year);

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void GetBottlesWithAlert_NoSorting_OK()
        {
            List<Bottles> resExpected = lstBottlesWithAlerts;
            List<Bottles> resCalculated = new List<Bottles>();

            resCalculated = Bottles.GetBottlesWithAlert(1);

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void GetBottlesWithName_NoSorting_OK()
        {
            Bottles resExpected = bottleByName;
            Bottles resCalculated = new Bottles();

            resCalculated = Bottles.GetBottleWithName("bouteille1");

            Assert.AreEqual(resExpected, resCalculated);
        }
    }
}
