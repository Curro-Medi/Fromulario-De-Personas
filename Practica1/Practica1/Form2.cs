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
    public partial class Form2 : Form
    {
         // hago referencia a la lista original
        List<Persona> referenciaAListaPersonas;
        Form1 f1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        public Form2(List<Persona> lp, Form1 f1)
        {
            InitializeComponent();
            referenciaAListaPersonas = lp;
            this.f1 = f1;
                      
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Boolean encontrado = false;
            int altura;
            int peso;
            int edad;

            for (int i = 0; i < referenciaAListaPersonas.Count(); i++) {

                if (textBox1.Text == referenciaAListaPersonas[i].DNI1)
                {
                    MessageBox.Show("ERROR, DNI REPETIDO");
                    f1.Show();
                    this.Hide();
                    //referenciaAListaPersonas.Remove(referenciaAListaPersonas[i]);
                    encontrado = true;
                }
            }

            if(encontrado == false)
            {
                altura = int.Parse(textBox4.Text);
                peso = int.Parse(textBox5.Text);
                edad = int.Parse(textBox6.Text);

                referenciaAListaPersonas.Add(new Persona(textBox1.Text, textBox2.Text, textBox3.Text, altura, peso, edad, textBox7.Text));

                f1.Show();
                this.Hide();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
