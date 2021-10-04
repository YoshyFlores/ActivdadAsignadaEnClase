using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animales
{
    class Animal
    {
        private string _foto { get; set; }
        private string _comida { get; set; }
        private string _localizacion { get; set; }
        private string _tamano { get; set; }


        // Create Methods

        public string gethacerRuido()
        {
            return _tamano;
        }
        public virtual void sethacerRuido(string Tamano)
        {
            _tamano = Tamano;
        }

        public string getcomer()
        {
            return _comida;
        }
        public virtual void setcomer(string Comida)
        {
            _comida = Comida;
        }
        public string getdormir()
        {
            return _foto;
        }

        public virtual void setdormir(string Foto)
        {
            _foto = Foto;
        }

        public string getrugir()
        {
            return _localizacion;
        }

        public virtual void setrugir(string Localizacion)
        {
            _localizacion = Localizacion;
        }

        public virtual string getAnimals()
        {
            return getcomer() + " . " + gethacerRuido();
        }
    }
}
