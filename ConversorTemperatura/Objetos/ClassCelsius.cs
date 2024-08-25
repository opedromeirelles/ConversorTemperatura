using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class ClassCelsius
    {
        public double cel { get; set; }
        public ClassCelsius()
        {
            
        }

        //CONVERSÕES DE X PARA CELSIUS

        public void convCelKel(double kel)
        {
            this.cel = kel - 275.15;
        }

        public void convCelFah(double fah)
        {
            this.cel = (fah - 32) * 5 / 9;
        }


        //get - set
        public double getCel()
        {
            return this.cel;
        }
        public void setCel(double valor)
        {
            this.cel = valor;
        }

    }
}
