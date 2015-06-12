using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
    public class Kunde
    {
        public String  KundenID { get; set;}
        public String Name { get; set;  }
        public String VName { get; set; }
        
        private String gebDat;
        public String GebDat
        {
            get { return gebDat; }
            set { gebDat = value; }
        }
        //public String GebDat { get; set; }
        public override string ToString()
        {
            return this.KundenID + ": " + this.Name + " - " + this.GebDat;
        }

    }
}
