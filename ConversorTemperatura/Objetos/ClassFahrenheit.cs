using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class ClassFahrenheit
    {
        public double fah { get; set; }
        public ClassFahrenheit()
        {
            
        }

        //CONVERSÕES DE X PARA FAHRENHEIT
        public void convFahCel(double cel)
        {
            this.fah = (cel * 9 / 5) + 32;
        }

        public void convFahKel(double kel)
        {
            this.fah = (kel - 275.15) * 9 / 5 + 32;
        }

        //get - set
        public double getFah()
        {
            return this.fah;
        }
        public void setFah(double valor)
        {
            this.fah = valor;
        }
    }
}
