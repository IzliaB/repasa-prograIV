using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repaso.Clases;

namespace Repaso
{
    public partial class Form1 : Form
    {

        List<REGISTROS> lista_registros = new List<REGISTROS>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Guardar()
        {
            REGISTROS nuevo = new REGISTROS();

            nuevo.identidad = control11.Text;
            nuevo.nombre = txtnombre.Text;
            nuevo.sexo = cbxsexo.Text;
            nuevo.fecha_nac = dtpfecha_nac.Value;


            lista_registros.Add(nuevo);

            MessageBox.Show("Registros en lista: "
                             + lista_registros.Count.ToString());
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Buscar()
        {
            foreach (REGISTROS ide in lista_registros)
            {
                if (ide.identidad == control11.Text)
                {
                    control11.Text = ide.identidad;
                    txtnombre.Text = ide.nombre;
                    cbxsexo.Text = ide.sexo;
                    dtpfecha_nac.Value = ide.fecha_nac;
                }
            }
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
