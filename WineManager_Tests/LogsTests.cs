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
    public class LogsTests
    {
        List<Logs> lstLogs = new List<Logs>();
        Logs logToAdd = new Logs("Ajout de quantité de bouteille", Convert.ToDateTime("28.05.2021 00:00:00"), "bouteille3");

        [TestInitialize]
        public void Initialize()
        {
            lstLogs = new List<Logs>() 
            {
                    new Logs("Ajout de bouteille", Convert.ToDateTime("20.04.2021 00:00:00"),"bouteille1"),
                    new Logs("Ajout de bouteille", Convert.ToDateTime("28.04.2021 00:00:00"),"bouteille3"),
                    new Logs("Ajout de bouteille", Convert.ToDateTime("05.05.2021 00:00:00"),"bouteille2")
        };
            logToAdd = new Logs("Ajout de quantité de bouteille", Convert.ToDateTime("28.05.2021 00:00:00"), "bouteille3");
        }

        [TestMethod]
        public void GetAllLogs_NoSorting_OK()
        {
            List<Logs> resExpected = lstLogs;
            List<Logs> resCalculated = new List<Logs>();

            resCalculated = Logs.GetAllLogs();

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void AddLog_AllParams_OK()
        {
            bool resExpected = true;
            bool resCalculated;

            resCalculated = Logs.AddLog("ajoutExistante",1);

            Assert.AreEqual(resExpected, resCalculated);
        }
    }
}
