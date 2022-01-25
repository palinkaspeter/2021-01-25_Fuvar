﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_01_25_Fuvar
{
    class Fuvar
    {
        public int TaxiID { get; set; }
        public string Indulás { get; set; }
        public int Időtartam { get; set; }
        public double Távolság { get; set; }
        public double VitelDíj { get; set; }
        public double Borravaló { get; set; }
        public string FizetésMód { get; set; }

        public Fuvar(string sor)
        {
            string[] t = sor.Split(';');
            TaxiID = int.Parse(t[0]);
            Indulás = t[1];
            Időtartam = int.Parse(t[2]);
            Távolság = double.Parse(t[3]);
            VitelDíj = double.Parse(t[4]);
            Borravaló = double.Parse(t[5]);
            FizetésMód = t[6];
        }
    }
}
