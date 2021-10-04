using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Gato:Felino
    {
        private string _vacuna { get; set; }

        public string getVacunar()
        {
            return _vacuna;
        }

        public void setVacunar(string Vacuna)
        {
            _vacuna = Vacuna;
        }

        public override string getAnimals()
        {
            return base.getAnimals() + " . " + getVacunar();
        }
    }
}
