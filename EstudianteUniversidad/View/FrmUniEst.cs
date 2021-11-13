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
    public partial class FrmUniEst : Form
    {
        BusinesLogic.Estudiante e = new BusinesLogic.Estudiante();
        BusinesLogic.Universidad u = new BusinesLogic.Universidad();
        BusinesLogic.UniEstudiante ue = new BusinesLogic.UniEstudiante();
        Controller.Validator v = new Controller.Validator();
        public FrmUniEst()
        {
            InitializeComponent();

            v.nInitCbo(this.CboEst);
            v.nInitCbo(this.CboUni);
            e.listadoEstudianteCbo(this.CboEst);
            u.listadoUniCbo(this.CboUni);
            this.MaximizeBox = false; //No permitir maximizar ventana
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        private void FrmUniEst_Load(object sender, EventArgs e)
        {

        }

        private void CboEst_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.CboEst.SelectedIndex == -1 || this.CboUni.SelectedIndex == -1)
            //Validar elementos no seleccionados
            {
                MessageBox.Show(this, "Debe seleccionar un elemento, revise e intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ue.Est = new BusinesLogic.Estudiante { PK_Estudiante = (int)CboEst.SelectedValue };
                ue.Uni = new BusinesLogic.Universidad { PK_Universidad = (int)CboUni.SelectedValue };

                if (ue.InscripcionEst() == true)
                {
                    MessageBox.Show("Estudiante inscrito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.CboEst.SelectedIndex = -1;
                    this.CboUni.SelectedIndex = -1;
                }
                else if (ue.InscripcionEst() == false)
                {
                    MessageBox.Show("Lo sentimos, ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
