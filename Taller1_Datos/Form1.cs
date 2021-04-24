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
using System.Windows.Forms.DataVisualization.Charting;

namespace Taller1_Datos
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\Windows 10\Desktop\DAVIPOLA_data\Taller1_Datos\Data\DANE.xlsx";
        public Form1()
        {
            InitializeComponent();
        }


        private void datos_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscarArchivos = new OpenFileDialog();
            if (buscarArchivos.ShowDialog() == DialogResult.OK)
            {
                txtDireccion.Text = path;
                loadData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadData()
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
                oPerson.municipaly = sl.GetCellValueAsString(iRow, 4);
                oPerson.type = sl.GetCellValueAsString(iRow, 5);
                lst.Add(oPerson);

                iRow++;
            }

            dataGridView1.DataSource = lst;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                dataGridView1.Columns["codDepar"].Visible = true;
                dataGridView1.Columns["codMun"].Visible = false;
                dataGridView1.Columns["departament"].Visible = false;
                dataGridView1.Columns["municipaly"].Visible = false;
                dataGridView1.Columns["type"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.Columns["codDepar"].Visible = false;
                dataGridView1.Columns["codMun"].Visible = true;
                dataGridView1.Columns["departament"].Visible = false;
                dataGridView1.Columns["municipaly"].Visible = false;
                dataGridView1.Columns["type"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.Columns["codDepar"].Visible = false;
                dataGridView1.Columns["codMun"].Visible = false;
                dataGridView1.Columns["departament"].Visible = true;
                dataGridView1.Columns["municipaly"].Visible = false;
                dataGridView1.Columns["type"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 3)
            {
                dataGridView1.Columns["codDepar"].Visible = false;
                dataGridView1.Columns["codMun"].Visible = false;
                dataGridView1.Columns["departament"].Visible = false;
                dataGridView1.Columns["municipaly"].Visible = true;
                dataGridView1.Columns["type"].Visible = false;
            }
            if (comboBox1.SelectedIndex == 4)
            {
                dataGridView1.Columns["codDepar"].Visible = false;
                dataGridView1.Columns["codMun"].Visible = false;
                dataGridView1.Columns["departament"].Visible = false;
                dataGridView1.Columns["municipaly"].Visible = false;
                dataGridView1.Columns["type"].Visible = true;
            }
        }

        //grafico
        private void chart1_Click(object sender, EventArgs e)
        {
            string[] series = {"Antioquia" };
            int[] puntos = { 0, 20, 40, 60, 80, 100, 120 };

            chart1.Palette = ChartColorPalette.Pastel;

            for (int i = 0; i < series.Length; i++)
            {

            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
