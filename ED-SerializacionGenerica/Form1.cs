using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED_SerializacionGenerica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string ruta = "alumno.dat";
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno
            {
                NumControl = txtNumControl.Text,
                Nombre = txtNombre.Text,
                Semestre = byte.Parse(txtSemestre.Text)
            };
            Serializador<Alumno> serializador = new Serializador<Alumno>();
            serializador.Guardar(ruta, a);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Serializador<Alumno> serializador = new Serializador<Alumno>();
            Alumno a = serializador.Cargar(ruta);
            lblNumControl.Text = a.NumControl;
            lblNombre.Text = a.Nombre;
            lblSemestre.Text = a.Semestre.ToString();
        }
    }
}
