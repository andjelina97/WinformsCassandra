using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class Wine
    {
        public String name { get; set; }
        public String country { get; set; }
        public double alcohol { get; set; }
        public String typeOfWine { get; set; }

        public Wine(string name, string country, double alcohol, string typeOfWine)
        {
            this.name = name;
            this.country = country;
            this.alcohol = alcohol;
            this.typeOfWine = typeOfWine;
        }
    }
}
