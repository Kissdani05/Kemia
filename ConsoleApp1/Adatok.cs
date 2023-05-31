using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{

    class Adatok
    {
        public string év;
        public string név;
        public string vegyjel;
        public int rendszam;
        public string felfedezo;

        public Adatok(string sor)
        {
            string[] darabok = sor.Split(';');
            this.év = darabok[0];
            this.név= darabok[1];
            this.vegyjel = darabok[2].ToLower();
            this.rendszam = Convert.ToInt32(darabok[3]);
            this.felfedezo = darabok[4];
        }
    }
    
}
