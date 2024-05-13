using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void operacionesBásicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
         {
                
                Saludo Saludo = new Saludo();
                Saludo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Datos_Personales Datos_Personales = new Datos_Personales();
            Datos_Personales.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Operaciones_Basicas Operaciones_Basicas = new Operaciones_Basicas();
            Operaciones_Basicas.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
