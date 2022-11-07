using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Se for numericUpDown, usar name.Value.ToString()
            double b = double.Parse(txbBase.Text);
            double a = double.Parse(txbAltura.Text);

            // Mostrar o resultado na txbResultado:
            txbResultado.Text = (b * a) / 2 + "";

            // Isso é tudo pessoal.
        }
    }
}
