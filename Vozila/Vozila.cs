using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozila
{
    internal class Vozila
    {
        public string Marka;
        public string Model;
        public int GodinaProizvodnje;
        public int Kilometraza;

        public Vozila(string marka, string model, int godinaProizvodnje, int kIlometraza)
        {
            Marka = marka;
            Model = model;
            GodinaProizvodnje = godinaProizvodnje;
            Kilometraza = kIlometraza;
        }

        public override string ToString()
        {
            return $"{Marka} {Model}, Godina: {GodinaProizvodnje}, Kilometraža: {Kilometraza} km";
            
        }
    }
}
