using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vydaje
{
    internal class Aplikace
    {
       
        private readonly Osoba osoba;
        private readonly List<Osoba> osoby = new List<Osoba>();

        public Aplikace() { }


        public void Start()
        {


        }

        public void VypisOsoby()
        {
            foreach (var item in osoby)
            {
                Console.WriteLine(item);
            }
        }
    }
}
