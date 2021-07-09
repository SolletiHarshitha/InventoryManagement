using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    public class InventoryUtility
    {
        public List<Rice> RiceList;
        public List<Wheat> WheatList;
        public List<Pulse> PulseList;

        public class Rice
        {
            public string Name;
            public int Price;
            public int Kg;
            public string Type;
        }

        public class Wheat
        {
            public string Name;
            public int Price;
            public int Kg;
            public string Type;
        }

        public class Pulse
        {
            public string Name;
            public int Price;
            public int Kg;
            public string Type;
        }

    }
}
