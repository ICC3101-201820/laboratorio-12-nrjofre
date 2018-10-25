using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace MVC
{
    public delegate void AgregarComidaDelegate(string nombre, string proteinas, string grasas, string carbohidratos);

    public partial class Form1 : Form
    {
        public event AgregarComidaDelegate OnAgregarComida;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OnAgregarComida != null)
            {
                OnAgregarComida.Invoke(nombreTextBox.Text, proteinasTextBox.Text, grasasTextBox.Text, carbohidratosTextBox.Text);
            }
        }

        public void AgregarComida(Comida comida)
        {
            ComidasList.Items.Add(comida);
        }

        private void proteinaslabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void contactosList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProteinasLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void EliminarBtn_Click(Comida comida)
        {
            ComidasList.Items.Remove(comida);
            ComidasList.Items.Remove(ComidasList.SelectedIndex);
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            ComidasList.Items.Remove(ComidasList.SelectedIndex);
        }

        private void proteinasTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
