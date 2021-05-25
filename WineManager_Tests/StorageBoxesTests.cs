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
    public class StorageBoxesTests
    {
        List<StorageBoxes> lstBoxes = new List<StorageBoxes>();
        StorageBoxes boxToAdd = new StorageBoxes("casier 4", "en bas à gauche");

        [TestInitialize]
        public void Initialize()
        {
            lstBoxes = new List<StorageBoxes>() 
            {
                    new StorageBoxes("casier 1", "en haut à droite"),
                    new StorageBoxes("casier 2", "en haut à gauche"),
                    new StorageBoxes("casier 3", "en bas à droite")
        };
            boxToAdd = new StorageBoxes("casier 4", "en bas à gauche");
        }

        [TestMethod]
        public void AddStorageWDesc_AllParams_OK()
        {
            bool resExpected = true;
            bool resCalculated;

            resCalculated = StorageBoxes.AddStorageWDesc(boxToAdd.Name, boxToAdd.Description);

            Assert.AreEqual(resExpected, resCalculated);
        }

        [TestMethod]
        public void RemoveStorage__OK()
        {
            bool resExpected = true;
            bool resCalculated;

            resCalculated = StorageBoxes.RemoveStorage(boxToAdd.Name);

            Assert.AreEqual(resExpected, resCalculated);
        }


    }
}
