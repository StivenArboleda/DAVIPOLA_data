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
using SpreadsheetLight;

namespace Taller1_Datos
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\Windows 10\Desktop\CSharp-Workshop\Taller1_Datos\Data\DANE.xlsx";
        public Form1()
        {
            InitializeComponent();
        }


        private void datos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarArchivos = new OpenFileDialog();
            if(buscarArchivos.ShowDialog() == DialogResult.OK)
            {
                txtDireccion.Text = path; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument(path);

            int iRow = 2;
            List<Principal> lst = new List<Principal>();
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(iRow, 1)))
            {
                Principal oPerson = new Principal();
                oPerson.codDepar = sl.GetCellValueAsString(iRow, 1);
                oPerson.codMun = sl.GetCellValueAsString(iRow, 2);
                oPerson.departament = sl.GetCellValueAsString(iRow, 3);
                oPerson.municipality = sl.GetCellValueAsString(iRow, 4);
                lst.Add(oPerson);

                iRow++;
            }

            dataGridView1.DataSource = lst;

        }


    }
}
