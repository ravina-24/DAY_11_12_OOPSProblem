using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace DAY_11_12_OOPSUingJASON
{
    public class FileReader
    {
        public List<Inventory> inventories = new List<Inventory>();

        public List<Inventory> GetInventry()
        {
            string text = File.ReadAllText("C:\\Users\\Hp\\Documents\\Data.json");
            inventories = JsonConvert.DeserializeObject<List<Inventory>>(text);
            return inventories;
        }

    }
}
