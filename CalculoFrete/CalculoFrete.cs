using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFrete
{
    public partial class CalculoFrete : Form
    {
        public CalculoFrete()
        {
            InitializeComponent();
        }

        private void Calcular()
        {
            decimal valor = 0;
            decimal porcentagem = 0;

            valor = Convert.ToDecimal(textBox2.Text);

            switch (comboBox1.Text)
            {
                case "AM":
                    porcentagem = 0.6m;
                    break;
                case "MG":
                    porcentagem = 0.35m;
                    break;
                case "RJ":
                    porcentagem = 0.30m;
                    break;
                case "SP":
                    porcentagem = 0.2m;
                    break;
                default:
                    porcentagem = 0.75m;
                    break;
            }

            textBox2.Text = valor.ToString("N2");
            textBox3.Text = porcentagem.ToString("P1");
            labelResul.Text = (valor * (1 + porcentagem)).ToString("c2");



        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            textBox3.Text = string.Empty;
            labelResul.Text = string.Empty;

            if (textBox1.Text.Trim().Equals(""))
            {
                MessageBox.Show("O Campo Nome é obrigatório", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Focus();
                return;
            }

            if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("O Campo Valor é obrigatório", "Alerte", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Focus();
                return;
            }

            Calcular();

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            labelResul.Text = string.Empty;
            textBox1.Focus();
        }
    }
}
