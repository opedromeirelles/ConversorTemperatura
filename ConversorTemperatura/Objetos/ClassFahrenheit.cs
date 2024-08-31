using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class ClassFahrenheit
    {
        private double _fah;

        public double TempFahrenheit
        {
            get
            {
                return _fah;
            }

            set
            {
                _fah = value;
            }
        }
        public ClassFahrenheit()
        {
            
        }

        //CONVERSÕES DE X PARA FAHRENHEIT
        public void convFahCel(double cel)
        {
            this.TempFahrenheit = (cel * 9 / 5) + 32;
        }

        public void convFahKel(double kel)
        {
            this.TempFahrenheit = (kel - 275.15) * 9 / 5 + 32;
        }
                
    }
}
