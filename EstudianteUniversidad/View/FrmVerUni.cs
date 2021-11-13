using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudianteUniversidad.View
{

    public partial class FrmVerUni : Form
    {
        Controller.Validator u = new Controller.Validator();
        BusinesLogic.Universidad d = new BusinesLogic.Universidad();
        public FrmVerUni()
        {
            InitializeComponent();
            u.InitCbo(CboPais);
            u.InitCbo(CboFundacion);
            this.CboPais.DataSource = u.ListadoPaises();
            this.CboFundacion.DataSource = Enumerable.Range(1900, 100).ToList();
            CboPais.SelectedIndex = -1;
            CboFundacion.SelectedIndex = -1;
            TxtId.Enabled = false;
            CargarDatos();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void CargarDatos()
        {
            d.listadoUniversidad(datauni);

            this.datauni.Columns[0].HeaderText = "Id";
            this.datauni.Columns[0].Width = 60;

            this.datauni.Columns[1].HeaderText = "Universidad";
            this.datauni.Columns[1].Width = 127;

            this.datauni.Columns[2].HeaderText = "Pais";
            this.datauni.Columns[2].Width = 125;

            this.datauni.Columns[3].HeaderText = "Ciudad";
            this.datauni.Columns[3].Width = 95;

            this.datauni.Columns[4].HeaderText = "Año de Fundación";
            this.datauni.Columns[4].Width = 60;
        }
        private void FrmVerUni_Load(object sender, EventArgs e)
        {

        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void datauni_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datauni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.TxtId.Text = datauni.CurrentRow.Cells[0].Value != null ? datauni.CurrentRow.Cells[0].Value.ToString() : string.Empty;
            this.TxtUniversidad.Text = datauni.CurrentRow.Cells[1].Value != null ? datauni.CurrentRow.Cells[1].Value.ToString() : string.Empty;
            this.CboPais.Text = datauni.CurrentRow.Cells[2].Value != null ? datauni.CurrentRow.Cells[2].Value.ToString() : string.Empty;
            this.TxtCiudad.Text = datauni.CurrentRow.Cells[3].Value != null ? datauni.CurrentRow.Cells[3].Value.ToString() : string.Empty;
            this.CboFundacion.Text = datauni.CurrentRow.Cells[4].Value != null ? datauni.CurrentRow.Cells[4].Value.ToString() : string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtUniversidad.Text) || String.IsNullOrEmpty(TxtCiudad.Text) || CboPais.SelectedIndex == -1 || CboFundacion.SelectedIndex == -1) //Validar campos vacios
            {
                MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtUniversidad.Focus();
            }
            else
            {
                d.PK_Universidad = Convert.ToInt32(this.TxtId.Text);
                d.Nombre = this.TxtUniversidad.Text;
                d.Pais = this.CboPais.SelectedItem.ToString();
                d.Ciudad = this.TxtCiudad.Text;
                d.AnioFundacion = (int)this.CboFundacion.SelectedItem;



                if (d.ActualizarUniversidad() == true)
                {
                    this.TxtId.Clear();
                    this.TxtUniversidad.Clear(); //Limpiar campos despues de guardar
                    this.CboPais.SelectedIndex = -1;
                    this.TxtCiudad.Clear();
                    this.CboFundacion.SelectedIndex = -1;
                    CargarDatos();

                    MessageBox.Show("Universidad actualizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (d.ActualizarUniversidad() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult di = MessageBox.Show("Esta seguro que desea eliminar esta Universidad", "Eliminar Universidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (di == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(TxtUniversidad.Text) || String.IsNullOrEmpty(TxtCiudad.Text) || CboPais.SelectedIndex == -1 || CboFundacion.SelectedIndex == -1) //Validar campos vacios
                {
                    MessageBox.Show(this, "Faltan campos requeridos, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUniversidad.Focus();
                }
                else
                {
                    d.PK_Universidad = Convert.ToInt32(this.TxtId.Text);
                    d.Nombre = this.TxtUniversidad.Text;
                    d.Pais = this.CboPais.SelectedItem.ToString();
                    d.Ciudad = this.TxtCiudad.Text;
                    d.AnioFundacion = (int)this.CboFundacion.SelectedItem;
                    d.Active = false;


                    if (d.EliminarUniversidad() == true)
                    {
                        this.TxtId.Clear();
                        this.TxtUniversidad.Clear(); //Limpiar campos despues de guardar
                        this.CboPais.SelectedIndex = -1;
                        this.TxtCiudad.Clear();
                        this.CboFundacion.SelectedIndex = -1;
                        CargarDatos();

                        MessageBox.Show("Universidad actualizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (d.EliminarUniversidad() == false)
                    {
                        MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
}
