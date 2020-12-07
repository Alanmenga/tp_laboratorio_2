using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            buttonLimpiar.Enabled = false;
            buttonConvBinario.Enabled = false;
            buttonConvDecimal.Enabled = false;
        }

        private void Operar_OnClick(object sender, EventArgs e)
        {
            string operador = Convert.ToString(comboBoxOperador.SelectedItem);
            labelNroResult.Text = Convert.ToString(Operar(textBoxNum1.Text, textBoxNum2.Text, operador));
            buttonConvBinario.Enabled = true;
            buttonConvDecimal.Enabled = true;
            buttonLimpiar.Enabled = true;
        }

        private static double Operar(string num1, string num2, string operador)
        {
            Numero n1 = new Numero(num1);
            Numero n2 = new Numero(num2);

            return Calculadora.Operar(n1,n2,operador);
        }

        private void Limpiar_OnClick(object sender, EventArgs e)
        {
            textBoxNum1.Clear();
            textBoxNum2.Clear();
            labelNroResult.Text = "----";
            buttonConvDecimal.Enabled = false;
            buttonConvBinario.Enabled = false;
            comboBoxOperador.Text = "";
        }

        private void Cerrar_OnClick(object sender, EventArgs e)
        {
            string message = "¿Seguro de querer salir?";
            string caption = "Error";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ConvBin_OnClick(object sender, EventArgs e)
        {
            string num = labelNroResult.Text;
            Numero nro = new Numero();
            labelNroResult.Text = nro.DecimalBinario(num);
        }

        private void ConvDeci_OnClick(object sender, EventArgs e)
        {
            string num = labelNroResult.Text;
            Numero nro = new Numero();
            labelNroResult.Text = nro.BinarioDecimal(num);
        }
    }
}
