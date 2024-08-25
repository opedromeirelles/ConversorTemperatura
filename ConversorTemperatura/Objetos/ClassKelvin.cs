using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class ClassKelvin
    {
        public double kel { get; set; }

        public ClassKelvin()
        {
            
        }

        //CONVERSÕES DE X PARA KELVIN
        public void convKelCel(double cel)
        {
            this.kel = cel + 273.15;
        }

        public void convKelFah(double fah)
        {
            this.kel = (fah - 32) * 5 / 9 + 273.15;
        }

        //get - set
        public double getKel()
        {
            return this.kel;
        }
        public void setKel(double valor)
        {
            this.kel = valor;
        }
    }
}
