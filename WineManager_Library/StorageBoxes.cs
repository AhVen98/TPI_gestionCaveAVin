using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineManager
{
    public class StorageBoxes
    {
        protected string name;
        protected string description;

        public StorageBoxes(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        static public List<StorageBoxes> ShowAllBoxes()
        {
            DBRequest req = new DBRequest();
            List<StorageBoxes> lstBox = req.GetAllBoxes();
            return lstBox;
        }

        static public bool AddStorageWDesc(string name, string desc)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.AddStorageWDesc(name, desc);

            return res;
        }

        static public bool AddStorage(string name)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.AddStorage(name);

            return res;
        }

        static public bool RemoveStorage(string name)
        {
            bool res = false;
            DBRequest req = new DBRequest();

            res = req.RemoveStorage(name);

            return res;
        }

        //all getter, to permit the application to view the data
        public string Name { get { return name; } }
        public string Description { get { return description; } }
    }
}
