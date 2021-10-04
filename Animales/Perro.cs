using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Perro:Canino
    {
        private string _sacarPaseo { get; set; }
        private string _vacuna { get; set; }

        public string getVacunar()
        {
            return _vacuna;
        }

        public void setVacunar(string Vacuna)
        {
            _vacuna = Vacuna;
        }
        public string getsacarPaseo()
        {
            return _sacarPaseo;
        }

        public void setsacarPaseo(string SacarPaseo)
        {
            _sacarPaseo = SacarPaseo;
        }

        public override string getAnimals()
        {
            return base.getAnimals() + " . " + getVacunar() + " . " + getsacarPaseo();
        }
    }
}
