using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTemperatura
{
    internal class ClassKelvin
    {
        private double _kel;

        public double TempKelvin
        {
            get
            {
                return _kel;
            }

            set
            {
                _kel = value;
            }
        }

        public ClassKelvin()
        {
            
        }

        //CONVERSÕES DE X PARA KELVIN
        public void convKelCel(double cel)
        {
            this.TempKelvin = cel + 273.15;
        }

        public void convKelFah(double fah)
        {
            this.TempKelvin = (fah - 32) * 5 / 9 + 273.15;
        }

        
    }
}
