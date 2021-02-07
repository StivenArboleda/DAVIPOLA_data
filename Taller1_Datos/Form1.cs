using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Taller1_Datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void datos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarArchivos = new OpenFileDialog();
            if(buscarArchivos.ShowDialog() == DialogResult.OK)
            {
                txtDireccion.Text = buscarArchivos.FileName; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        }
    }
}
