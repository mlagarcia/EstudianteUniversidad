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
    public partial class FrmAgregarUni : Form
    {
        BusinesLogic.Universidad est = new BusinesLogic.Universidad();
        Controller.Validator v = new Controller.Validator();
        public FrmAgregarUni()
        {
            InitializeComponent();
            v.InitCbo(this.CboAnio);
            v.InitCbo(this.CboPais);
            this.CboAnio.DataSource = Enumerable.Range(1900, 100).ToList();
            this.CboPais.DataSource = v.ListadoPaises();
            this.CboPais.SelectedIndex = 168;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtNombre.Text) || this.CboPais.SelectedIndex == -1 || String.IsNullOrEmpty(TxtCiudad.Text)) //Validar campos vacios
            {
                MessageBox.Show(this, "Los campos con astericos son obligatorios, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtNombre.Focus();
            }
            else
            {
                est.Nombre = this.TxtNombre.Text;
                est.Pais = this.CboPais.SelectedItem.ToString();
                est.Ciudad= this.TxtCiudad.Text;
                est.AnioFundacion = (int) this.CboAnio.SelectedItem;

                if (est.AgregarUniversidad() == true)
                {
                    this.TxtNombre.Clear(); //Limpiar campos despues de guardar
                    this.CboPais.SelectedIndex = 168;
                    this.TxtCiudad.Clear();
                    this.CboAnio.SelectedIndex = 0;

                    MessageBox.Show("Universidad guardadada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (est.AgregarUniversidad() == false)
                {
                    MessageBox.Show("Ha ocurrido un error", "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FrmAgregarUni_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    }

