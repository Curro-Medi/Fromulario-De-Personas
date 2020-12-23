using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1
{
    public partial class Form4 : Form
    {
        List<Persona> referenciaAListaPersonas;
        Form1 f1;
        public Form4()
        {
            InitializeComponent();
        }
        public Form4(List<Persona> lp, Form1 f1)
        {
            InitializeComponent();
            referenciaAListaPersonas = lp;
            this.f1 = f1;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            f1.Show();
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Boolean encontrado = false;

            for (int i = 0; i < referenciaAListaPersonas.Count(); i++)
            {
               

                if (referenciaAListaPersonas[i].DNI1 == busqueda.Text)
                {
                    buscado.Items.Add(referenciaAListaPersonas[i].ToString());
                    encontrado = true;
                }

                          
            }
            if (encontrado == false)
            {
                MessageBox.Show("Persona no encontrada");
            }
            encontrado = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void busqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
