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
        private double _cel;

        public double TempCelsius
        {
            get
            {
                return _cel;
            }

            set
            {
                _cel = value;
            }
        }
        public ClassCelsius()
        {
            
        }

        //CONVERSÕES DE X PARA CELSIUS

        public void convCelKel(double kel)
        {
            this.TempCelsius = kel - 275.15;
        }

        public void convCelFah(double fah)
        {
            this.TempCelsius = (fah - 32) * 5 / 9;
        }

    }
}
