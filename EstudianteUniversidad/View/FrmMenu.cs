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
    public partial class FrmMenu : Form
    {
        Form1 a;
        FrmVerEstudiante ve;
        FrmAgregarUni au;
        FrmVerUni ver;
        FrmUniEst un;
        FrmVerUniEst ues;
        private int childFormNumber = 0;

        public FrmMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = false;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (a == null)
            {
                a = new Form1();
                a.FormClosed += new FormClosedEventHandler(A_FormClosed);
                a.MdiParent = this;
                a.Show();
            }
            else
            {
                a.WindowState = FormWindowState.Normal;
            }
        }

        private void A_FormClosed(object sender, FormClosedEventArgs e)
        {
            a = null;
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void verEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ve == null)
            {
                ve = new FrmVerEstudiante();
                ve.FormClosed += new FormClosedEventHandler (Ve_FormClosed);
                ve.MdiParent = this;
                ve.Show();
            }
            else
            {
                ve.WindowState = FormWindowState.Normal;
            }

        }

        private void Ve_FormClosed(object sender, FormClosedEventArgs e)
        {
            ve = null;
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (au == null)
            {
                au = new FrmAgregarUni();
                au.FormClosed += new FormClosedEventHandler(Au_FormClosed);
                au.MdiParent = this;
                au.Show();
            }
            else
            {
                au.WindowState = FormWindowState.Normal;
            }
        }

        private void Au_FormClosed(object sender, FormClosedEventArgs e)
        {
            au = null;
        }

        private void verUniversidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ver == null)
            {
                ver = new FrmVerUni();
                ver.FormClosed += new FormClosedEventHandler(Ver_FormClosed); 
                ver.MdiParent = this;
                ver.Show();
            }
            else
            {
                ver.WindowState = FormWindowState.Normal;
            }

        }

        private void Ver_FormClosed(object sender, FormClosedEventArgs e)
        {
            ver = null;

        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inscribirEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (un == null)
            {
                un = new FrmUniEst();
                un.FormClosed += new FormClosedEventHandler(Un_FormClosed);
                un.MdiParent = this;
                un.Show();
            }
            else
            {
                un.WindowState = FormWindowState.Normal;
            }
        }

        private void Un_FormClosed(object sender, FormClosedEventArgs e)
        {
            un = null;
        }

        private void verInscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ues == null)
            {
                ues = new FrmVerUniEst();
                ues.FormClosed += new FormClosedEventHandler(Ues_FormClosed);
                ues.MdiParent = this;
                ues.Show();
            }
            else
            {
                ues.WindowState = FormWindowState.Normal;
            }
        }

        private void Ues_FormClosed(object sender, FormClosedEventArgs e)
        {
            ues = null;
        }
    }
}
