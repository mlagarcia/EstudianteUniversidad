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
    public partial class FrmVerUniEst : Form
    {
        BusinesLogic.UniEstudiante ue = new BusinesLogic.UniEstudiante();
        Controller.Validator v = new Controller.Validator();
        public FrmVerUniEst()
        {
            InitializeComponent();
            CargarDatos();
            this.MaximizeBox = false; //No permitir maximizar ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CboTipoBusqueda.DataSource = v.ListaTipoBusquedaIns();
            this.CboTipoBusqueda.SelectedIndex = 0;
        }

        private void FrmVerUniEst_Load(object sender, EventArgs e)
        {

        }

        public void CargarDatos()
        {
            ue.listadoUniEst(dataGrid);

            this.dataGrid.Columns[0].HeaderText = "ID";
            this.dataGrid.Columns[0].Width = 60;

            this.dataGrid.Columns[1].HeaderText = "Nombre";
            this.dataGrid.Columns[1].Width = 120;

            this.dataGrid.Columns[2].HeaderText = "Apellido";
            this.dataGrid.Columns[2].Width = 120;

            this.dataGrid.Columns[3].HeaderText = "Universidad";
            this.dataGrid.Columns[3].Width = 100;

            this.dataGrid.Columns[4].HeaderText = "Pais";
            this.dataGrid.Columns[4].Width = 100;

            this.dataGrid.Columns[5].HeaderText = "Ciudad";
            this.dataGrid.Columns[5].Width = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CboTipoBusqueda.SelectedIndex == 0)
            {
                ue.listadoBuscarPorNombre(dataGrid, this.TxtBusqueda.Text);
            }

            if (CboTipoBusqueda.SelectedIndex == 1)
            {
                ue.listadoBuscarPorApellido(dataGrid, this.TxtBusqueda.Text);
            }

            if (CboTipoBusqueda.SelectedIndex == 2)
            {
                ue.listadoBusquedaPorUniversidad(dataGrid, this.TxtBusqueda.Text);
            }
        }

        private void TxtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.button1.PerformClick();
            }
        }
    }
}
