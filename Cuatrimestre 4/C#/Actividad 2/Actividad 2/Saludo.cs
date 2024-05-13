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
    public partial class Saludo : Form
    {
        public Saludo()
        {
            InitializeComponent();
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.Saludar1 Saludara = new Clases.Saludar1();
            string MiSaludo = Saludara.Saludar(textBox1.Text);
            MessageBox.Show(MiSaludo);

                }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
