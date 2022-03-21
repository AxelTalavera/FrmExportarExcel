using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

using Microsoft.Office.Interop.Excel;

namespace FrmExportarExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            export(DtgvExcel);
        }
        public void export(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application execl = new Microsoft.Office.Interop.Excel.Application();  //Se crea el Objeto
            execl.Application.Workbooks.Add(true);//Se agrega una hoja

            int indiceColumna= 0;

            foreach(DataGridViewColumn col in tabla.Columns)//columnas
            {
                indiceColumna++;
                execl.Cells[1, indiceColumna] = col.Name; //se aumenta el indice de la columna 

            }

            int indiceFila = 0;
            foreach( DataGridViewRow row in tabla.Rows) //se recorren las filas por fils
            {
                indiceFila++;
                indiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns) //Columna por columna
                {
                    indiceColumna++;
                    execl.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                }

            }
            execl.Visible= true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DtgvExcel.Columns.Add("Nombre", "Nombre");
            DtgvExcel.Columns.Add("Apellido", "Apellido");
            DtgvExcel.Columns.Add("Direccion", "Direccion");
            DtgvExcel.Columns.Add("Telefono", "telefono");
        }

        private void BtnGuardarD_Click(object sender, EventArgs e)
        {
            DtgvExcel.Rows.Add(TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text, TxtTelefono.Text);
            TxtNombre.Text = "";
            TxtApellido.Text = "";
            TxtDireccion.Text = "";
            TxtTelefono.Text = "";
        }

        private void DtgvExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
