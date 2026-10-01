using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_ejercicio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int N1 = int.Parse(TextBB1.Text);
            int N2 = int.Parse(TextBB2.Text);
            int N3 = 1;
            int Potencia = 1;

            while (N3!= N2)
            {

                Potencia = Potencia * N1;
                N3 = N3 + 1;
             }
            MessageBox.Show("el resultado de la potencia es" + Potencia);
        }
        private void Suma_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextBB1.Text);
            int Num2 = int.Parse(TextBB2.Text);
            int suma = Num1 * Num2;
            MessageBox.Show("el resulyado de la suma es " + suma);

        }

        private void Producto_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextBB1.Text);
            int Num2 = int.Parse(TextBB2.Text);
            int producto = Num1 * Num2;
            MessageBox.Show("el resultado del producto es " + Producto);

        }

        private void Form2_Load(object sender, EventArgs e);
        
       

        private void Division_Click(object sender, EventArgs e)
        {
            float num1 = int.Parse(TextBB1.Text);
            float num2 = int.Parse(TextBB2.Text);
           
            if (num2 > 0)
          {
                float division = num1 / num2;

                MessageBox.Show("el resultado es " + Division ) ;

            }
           
            {

                MessageBox.Show("La Division es indifinida");
            }


    }

        private void Factorial_Click(object sender, EventArgs e)
        {
            int Num1 = int.Parse(TextBB1.Text);
            int Num2 = 1;
            for (int Num3 = 0; Num3 == Num2; Num3++);
            {
                Num2 = Num2 * Num2;
        }
            MessageBox.Show("el resultado del factorial es " + Num2);
    }

}
}
