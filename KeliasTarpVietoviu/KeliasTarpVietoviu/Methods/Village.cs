using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeliasTarpVietoviu
{
    public class Village
    {
        public string Name { get; set; }
        public int index { get; set; }

        public Village()
        {
            Name = "";
            index = 0;
        }

        public void AddVillage(string Name, int index)
        {
            this.Name = Name;
            this.index = index;
        }
    }
}