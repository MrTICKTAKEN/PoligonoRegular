using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoligonoRegular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numLado = int.Parse(textBox1.Text);
            double longitudLado = double.Parse(textBox2.Text);

            double perimetro = CalcularPerimetro (numLado, longitudLado);

            label1.Text = (" El perimetro del poligono regular con " + numLado + " lado y longitud de lado " + longitudLado + " es: " + perimetro);


        }
        private double CalcularPerimetro(int numLado, double longitudLado)
        {
            return numLado * longitudLado;
            throw new NotImplementedException();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
