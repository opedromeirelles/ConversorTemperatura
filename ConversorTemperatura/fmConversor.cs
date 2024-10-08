﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace ConversorTemperatura
{
    public partial class fmConversor : Form
    {
        ClassCelsius celsius = new ClassCelsius();
        ClassKelvin kelvin = new ClassKelvin();
        ClassFahrenheit fahrenheit = new ClassFahrenheit();


        public fmConversor()
        {
            InitializeComponent();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (verificaEntrada())
            {
                valorTemperatura();  
            }           
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorTemp.Clear();
            txtValorConv1.Clear();
            txtValorConv2.Clear();

        }
        private void cbTemperatura_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rotina de Opções
            opcaoTemp();

        }
        public bool verificaEntrada()
        {
            double valorTemp;
            try
            {
                valorTemp = Convert.ToDouble(txtValorTemp.Text);
                if(cbTemperatura.Text == "")
                {
                    MessageBox.Show("Por favor, selecione uma temperatura.", "Erro ao Calcular");
                    txtValorConv1.Clear();
                    txtValorConv2.Clear();
                    txtValorTemp.Clear();

                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, digite um valor numérico.", "Erro ao Calcular");
                txtValorTemp.Clear();
                return false;
            }
            
        }
        public void valorTemperatura()
        {
            if (cbTemperatura.Text == "CELSIUS")
            {
                double valorTemp = double.Parse(txtValorTemp.Text, CultureInfo.CurrentCulture);
                celsius.TempCelsius = valorTemp;

                kelvin.convKelCel(celsius.TempCelsius);
                fahrenheit.convFahCel(celsius.TempCelsius);

                txtValorConv1.Text = Math.Round(fahrenheit.TempFahrenheit, 2).ToString();
                txtValorConv2.Text = Math.Round(kelvin.TempKelvin, 2).ToString();


            }
            else if (cbTemperatura.Text == "KELVIN")
            {
                double valorTemp = double.Parse(txtValorTemp.Text, CultureInfo.CurrentCulture);
                kelvin.TempKelvin = valorTemp;

                fahrenheit.convFahKel(kelvin.TempKelvin);
                celsius.convCelKel(kelvin.TempKelvin);

                txtValorConv1.Text = Math.Round(fahrenheit.TempFahrenheit, 2).ToString();
                txtValorConv2.Text = Math.Round(celsius.TempCelsius, 2).ToString();

            }
            else
            {
                double valorTemp = double.Parse(txtValorTemp.Text, CultureInfo.CurrentCulture);
                fahrenheit.TempFahrenheit = valorTemp;

                celsius.convCelFah(fahrenheit.TempFahrenheit);
                kelvin.convKelFah(fahrenheit.TempFahrenheit);

                txtValorConv1.Text = Math.Round(kelvin.TempKelvin, 2).ToString();
                txtValorConv2.Text = Math.Round(celsius.TempCelsius, 2).ToString();

            }

        }
        public void opcaoTemp()
        {
            //Verirficar qual temperatura está seleinada.
            if (cbTemperatura.SelectedItem.Equals("CELSIUS"))
            {
                lblValorConv1.Text = "FAHRENHEIT";
                lblValorConv2.Text = "KELVIN";

            }
            else if (cbTemperatura.SelectedItem.Equals("KELVIN"))
            {
                lblValorConv1.Text = "FAHRENHEIT";
                lblValorConv2.Text = "CELSIUS";
            }
            else
            {
                lblValorConv1.Text = "KELVIN";
                lblValorConv2.Text = "CELSIUS";
            }

        }

        
    }
}
