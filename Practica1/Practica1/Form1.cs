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
    public partial class Form1 : Form
    {
        // creo el objeto en forms 1 un list con tipo de dato persona, la clase
        List<Persona> listapersonas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
            listapersonas.Add(new Persona("26366378E", "Pedro", "Ramirez", 150, 60, 15, "20/03/2019"));
            listapersonas.Add(new Persona("26364478S", "Roger", "Marti", 169, 140, 19, "10/11/2001"));
            listapersonas.Add(new Persona("", "Wissam", "Ben Yedder", 172, 70, 31, "10/11/1987"));
            listapersonas.Add(new Persona("98271939P", "Ansu", "Fati", 175, 50, 17, "10/11/2003"));
            listapersonas.Add(new Persona("82937467M", "", "Rakitic", 181, 80, 32, "10/11/1970"));
            listapersonas.Add(new Persona("88292287F", "Jules", "Kounde", 180, 80, 21, "10/11/1998"));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Le paso la lista creada antes creando el objeto forms2
            Form2 f2 = new Form2(listapersonas, this);
            this.Hide();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(listapersonas, this);
            this.Hide();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(listapersonas, this);
            this.Hide();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(listapersonas, this);
            this.Hide();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6(listapersonas, this);
            this.Hide();
            f6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
