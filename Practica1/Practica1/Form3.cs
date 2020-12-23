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
    public partial class Form3 : Form
    {

        Form1 f1;
        List<Persona> referenciaAListaPersonas;
        public Form3()
        {
            InitializeComponent();
            
        }

        public Form3(List<Persona> lp, Form1 f1)
        {
            this.f1 = f1;
                      
            InitializeComponent();
            referenciaAListaPersonas = lp;
           /* foreach (Persona person in referenciaAListaPersonas)
            {
                cont = cont + 1;
                listBox1.Items.Add(cont + ")  " + person);
            } */
            dataGridView1.DataSource = referenciaAListaPersonas;

            textBox1.Text = "" + referenciaAListaPersonas.Count();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            f1.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
