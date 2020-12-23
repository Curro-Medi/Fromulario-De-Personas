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
    public partial class Form5 : Form
    {
        List<Persona> referenciaAListaPersonas;
        Form1 f1;
        public Form5()
        {
            InitializeComponent();
        }
        public Form5(List<Persona> lp, Form1 f1)
        {
            InitializeComponent();
            referenciaAListaPersonas = lp;
            this.f1 = f1;
            int cont = 0; //para controlar que si hay mas de 3 con la misma longitud del nombre se acabe 
            int cont1 = 0; //controla el paso en el primer if del nombre mas largo
            int cont2 = 0;  //controla el segundo npmbre mas largo
            int cont3 = 0;  //controla el tercer nombre mas largo

            List<string> personas = new List<string>();

            foreach (Persona person in referenciaAListaPersonas)
            {
                
                if(person.Nombre.Length >= cont1)
                {
                    cont1 = person.Nombre.Length;

                    personas.Add(person.Nombre);
                    cont = cont + 1;
                }

                if(cont == 3){

                    break;
                }
                else
                {

                    if (person.Nombre.Length >= cont2 && person.Nombre.Length != cont1)
                    {
                        cont2 = person.Nombre.Length;

                        personas.Add(person.Nombre);

                        cont = cont + 1 ;
                    }

                    if (cont == 3)
                    {

                        break;
                    }

                    else
                    {

                        if (person.Nombre.Length >= cont3 && person.Nombre.Length != cont1 && person.Nombre.Length != cont2)
                        {
                            cont3 = person.Nombre.Length;

                            personas.Add(person.Nombre);
                        }
                    }

                }

            }

            listBox1.Items.Add(personas);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            f1.Show();
            this.Hide();
        }
    }
}
