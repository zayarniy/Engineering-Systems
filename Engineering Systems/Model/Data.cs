using System;
using System.Collections.Generic;
using System.Text;

namespace Engineering_Systems
{
    class Data
    {
        public string Item { get; set; }
        public int Value { get; set; }

        public Data(string Item, int Value)
        {
            this.Item = Item;
            this.Value = Value;
        }
    }

    class Database
    {
        public List<Data> Boilers = new List<Data>();

        public Database()
        {
            Boilers.Add(new Data("Нет", 0));
            Boilers.Add(new Data("Газовый", 100));
            Boilers.Add(new Data("Электро", 150));
            Boilers.Add(new Data("Каскад", 200));            
        }
    }
    
}
