using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudianteUniversidad
{
    public partial class Form1 : Form
    {
        BusinesLogic.Estudiante est = new BusinesLogic.Estudiante();
        public Form1()
        {
            InitializeComponent();
            this.radioButton1.Checked = true; //Radio buton seleccionado por default 
            this.FechaNac.Value = new DateTime(1999, 01, 01); //Fecha seleccionada por default
            this.MaximizeBox = false; //No permitir maximizar ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtNombre.Text) || String.IsNullOrEmpty(TxtApellido.Text)) //Validar campos vacios
            {
                MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
            }
            else
            {
                est.Nombre = this.TxtNombre.Text;
                est.Apellido = this.TxtApellido.Text;
                est.FechaDeNac = this.FechaNac.Value.Date;

                if (radioButton1.Checked == true)
                {
                    est.sexo = "Masculino";
                }
                else { est.sexo = "Femenino"; }

                if (est.AgregarEstudiante() == true)
                {
                    this.TxtNombre.Clear(); //Limpiar campos despues de guardar
                    this.TxtApellido.Clear();
                    this.radioButton1.Checked = true;
                    this.FechaNac.Value = new DateTime(1999, 01, 01);

                    MessageBox.Show("Cliente guardado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (est.AgregarEstudiante() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
