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
    public partial class Form6 : Form
    {
        List<Persona> referenciaAListaPersonas;
        Form1 f1;

        public Form6()
        {

        }
        public Form6(List<Persona> lp, Form1 f1)
        {
            InitializeComponent();
            referenciaAListaPersonas = lp;
            this.f1 = f1;
            int cont = 0;


            for (int i = 0; i < referenciaAListaPersonas.Count(); i++)
            {
                if (referenciaAListaPersonas[i].Apellidos.Equals("") || referenciaAListaPersonas[i].Nombre.Equals("") ||
                    referenciaAListaPersonas[i].DNI1.Equals("") || referenciaAListaPersonas[i].Fecha_nac.Equals("")) {
                    cont = cont + 1;
                    listBox1.Items.Add(cont + ")  " + referenciaAListaPersonas[i]);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
