using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EstudianteUniversidad.BusinesLogic;

namespace EstudianteUniversidad.View
{
    public partial class FrmVerEstudiante : Form
    {
        Estudiante es = new Estudiante();
        public FrmVerEstudiante()
        {
            InitializeComponent();
            CargarDatos(); //Invoca a metodo de carga de datos al cargar el formularo

            this.TxtId.Enabled = false; //Definir el campo TxtId como no editable
            this.radioButton1.Checked = true; //Radio button seleccionado por default
            this.MaximizeBox = false; //No permitir maximizar ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.TxtId.Text) || String.IsNullOrEmpty(this.TxtNombre.Text) || String.IsNullOrEmpty(this.TxtNombre.Text)) 
                //Validar campos vacions
            {
                MessageBox.Show(this, "Ha ocurrido un error, revise los campos e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TxtNombre.Focus();
            }
            else
            {
                es.PK_Estudiante = Convert.ToInt32(this.TxtId.Text);
                es.Nombre = this.TxtNombre.Text;
                es.Apellido = this.TxtApellido.Text;
                es.FechaDeNac = this.FechaNac.Value.Date;

                if (radioButton1.Checked == true)
                {
                    es.sexo = "Masculino";
                }
                else { es.sexo = "Femenino"; }

                es.Active = true;

                if (es.ActualizarEstudiante() == true)
                {
                    MessageBox.Show("Estudiante actualizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos(); //Recargar datos a la tabla
                    this.TxtId.Clear(); //Limpiar campos
                    this.TxtNombre.Clear();
                    this.TxtApellido.Clear();
                    this.radioButton1.Checked = true;
                    this.FechaNac.Value = new DateTime(1999, 01, 01);
                }
                else if (es.ActualizarEstudiante() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        public void CargarDatos()  //Metodo de carga de datos
        {
            es.listadoEstudiante(dataEst);

            this.dataEst.Columns[0].HeaderText = "Id";
            this.dataEst.Columns[0].Width = 60;

            this.dataEst.Columns[1].HeaderText = "Nombre";
            this.dataEst.Columns[1].Width = 120;

            this.dataEst.Columns[2].HeaderText = "Apellido";
            this.dataEst.Columns[2].Width = 120;

            this.dataEst.Columns[3].HeaderText = "Fecha de Nacimiento";
            this.dataEst.Columns[3].Width = 95;

            this.dataEst.Columns[4].HeaderText = "Sexo";
            this.dataEst.Columns[4].Width = 60;
        }

        private void FrmVerEstudiante_Load(object sender, EventArgs e)
        {

        }

        private void dataEst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataEst_CellClick(object sender, DataGridViewCellEventArgs e) //Pasar datos de grid a campos
        {
            this.TxtId.Text = dataEst.CurrentRow.Cells[0].Value != null ? dataEst.CurrentRow.Cells[0].Value.ToString() : string.Empty;
            this.TxtNombre.Text = dataEst.CurrentRow.Cells[1].Value != null ? dataEst.CurrentRow.Cells[1].Value.ToString() : string.Empty;
            this.TxtApellido.Text = dataEst.CurrentRow.Cells[2].Value != null ? dataEst.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            this.FechaNac.Text = dataEst.CurrentRow.Cells[3].Value != null ? dataEst.CurrentRow.Cells[3].Value.ToString() : string.Empty;

            String sexo = dataEst.CurrentRow.Cells[4].Value != null ? dataEst.CurrentRow.Cells[4].Value.ToString() : string.Empty;
            if (sexo == "Masculino")
            {
                radioButton1.Checked = true;
            }
            else { radioButton2.Checked = true; }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Esta seguro que desea eliminar este estudiante", "Eliminar estudiante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //Mostrar formulario de si o no
             
            if (d == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(this.TxtId.Text) || String.IsNullOrEmpty(this.TxtNombre.Text) || String.IsNullOrEmpty(this.TxtNombre.Text))
                    //Validar campos vacios
                {
                    MessageBox.Show(this, "Ha ocurrido un error, revise los campos e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    es.PK_Estudiante = Convert.ToInt32(this.TxtId.Text);
                    es.Nombre = this.TxtNombre.Text;
                    es.Apellido = this.TxtApellido.Text;
                    es.FechaDeNac = this.FechaNac.Value.Date;

                    if (radioButton1.Checked == true)
                    {
                        es.sexo = "Masculino";
                    }
                    else { es.sexo = "Femenino"; }

                    es.Active = false;

                    if (es.EliminarEstudiante() == true)
                    {
                        MessageBox.Show("Estudiante eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos(); //Recargar datos
                        this.TxtId.Clear(); //Limpiar campos
                        this.TxtNombre.Clear();
                        this.TxtApellido.Clear();
                        this.radioButton1.Checked = true;
                        this.FechaNac.Value = new DateTime(1999, 01, 01);
                    }
                    else if (es.EliminarEstudiante() == false)
                    {
                        MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

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
