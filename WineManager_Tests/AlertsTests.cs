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
    public class AlertsTests
    {
        List<Alerts> lstAlerts = new List<Alerts>();
        Alerts alertToAdd = new Alerts("ajout d'alerte", "ceci est un ajout d'alerte", "cépageTest 5");

        [TestInitialize]
        public void Initialize()
        {
            lstAlerts = new List<Alerts>() 
                { 
                    new Alerts("alerte1", "message1", "bouteille1"), 
                    new Alerts("alerte2", "message2", "bouteille2"), 
                    new Alerts("alerte3", "message3", "bouteille3"), 
                    new Alerts("alerte4", "message4", "bouteille4") 
                };
            alertToAdd = new Alerts("ajout d'alerte", "ceci est un ajout d'alerte", "cépageTest 5");
        }

        [TestMethod]
        public void ShowAllAlerts_NoSorting_OK()
        {
            List<Alerts> resExpected = lstAlerts;
            List<Alerts> resCalculated = new List<Alerts>();

            resCalculated = Alerts.ShowAllAlerts();

            Assert.AreEqual(resExpected, resCalculated);
        }


        [TestMethod]
        public void AddAlerts_AllParams_OK()
        {
            bool resExpected = true;
            bool resCalculated;

            resCalculated = Alerts.AddAlert(alertToAdd.Name, alertToAdd.Message);

            Assert.AreEqual(resExpected, resCalculated);
        }


        [TestMethod]
        public void DelAlerts_AllParams_OK()
        {
            bool resExpected = true;
            bool resCalculated;

            resCalculated = Alerts.DelAlert(alertToAdd.Name);

            Assert.AreEqual(resExpected, resCalculated);
        }


    }
}
