using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vydaje
{ 
     abstract class Clovek
    {
        public string Jmeno { get; set; }

        public string Prijmeni { get; set; }

        public DateTime DatumNarozeni { get; set; }

        private static int Id = 1;

        private int _id;

        public double Vek => VekOsoby();

        public string CeleJmeno => JmenoVelkym() + " " + PrijmeniVelkym();

        public Clovek(string jmeno, string prijmeni, DateTime datumNarozeni)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            _id= Id;
            Id++;
        }
        public override string ToString()
        {
            return string.Format("ID: {0} - {1}, věk : {2}" ,_id, CeleJmeno,Vek);
        }

       string JmenoVelkym()
        {
            return Jmeno.Substring(0, 1).ToUpper() + Jmeno.Substring(1);
        }

       string PrijmeniVelkym()
        {
            return Prijmeni.Substring(0, 1).ToUpper() + Prijmeni.Substring(1);
        }

        private double VekOsoby()
        {
            TimeSpan ts = DateTime.Now - DatumNarozeni;
            double vek = Math.Round((ts.Days/365.25));
            return vek;
        }
    }
}
