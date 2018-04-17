using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matriz
{
    public partial class Form1 : Form
    {
        Matriz m = new Matriz();
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdLlenar_Click(object sender, EventArgs e)
        {
            
            m.Llenar();
        }

        private void cmdLlenarxCol_Click(object sender, EventArgs e)
        {
            m.LlenarXC();
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            txtTable.Text = m.Mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTable.Clear();
        }

        private void cmdLlenarInv_Click(object sender, EventArgs e)
        {
            m.LlenarInv();
        }

        private void cmdMDP_Click(object sender, EventArgs e)
        {
           txtTable.Text+= m.mostrarDP();
                
        }

        private void cmdMDS_Click(object sender, EventArgs e)
        {
            txtTable.Text += m.MostrarDS();
        }

        private void cmdADP_Click(object sender, EventArgs e)
        {
            txtTable.Text += m.MostrarArDS();
        }

        private void GDP_Click(object sender, EventArgs e)
        {
            m.girarDP();
        }

        private void GDS_Click(object sender, EventArgs e)
        {
            m.girarDS();
        }
    }
}
