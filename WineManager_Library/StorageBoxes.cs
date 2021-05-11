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

        //all getter, to permit the application to view the data
        public string Name { get { return name; } }
        public string Description { get { return description; } }
    }
}
