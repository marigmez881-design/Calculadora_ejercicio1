using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Textusuario_TextChanged(object sender, EventArgs e)
        {
            if (Textusuario.Text== "5t0PCB" && TextClave.Text=="ejercicio")
            {
                this.Hide();
                MessageBox.Show();

            }
            else
            {
                MessageBox.Show("sus datos son Ivalidos porfavor intente de nuevo");
            }
            {
                
            }
        }
}
