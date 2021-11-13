
namespace EstudianteUniversidad.View
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.universidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verUniversidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscribirEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInscripcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.inscripcionesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.universidadToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(75, 21);
            this.fileMenu.Text = "&Opciones";
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.verEstudiantesToolStripMenuItem});
            this.estudianteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.estudianteToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // verEstudiantesToolStripMenuItem
            // 
            this.verEstudiantesToolStripMenuItem.Name = "verEstudiantesToolStripMenuItem";
            this.verEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.verEstudiantesToolStripMenuItem.Text = "Ver Estudiantes";
            this.verEstudiantesToolStripMenuItem.Click += new System.EventHandler(this.verEstudiantesToolStripMenuItem_Click);
            // 
            // universidadToolStripMenuItem
            // 
            this.universidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.verUniversidadToolStripMenuItem});
            this.universidadToolStripMenuItem.Name = "universidadToolStripMenuItem";
            this.universidadToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.universidadToolStripMenuItem.Text = "Universidad";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(168, 22);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // verUniversidadToolStripMenuItem
            // 
            this.verUniversidadToolStripMenuItem.Name = "verUniversidadToolStripMenuItem";
            this.verUniversidadToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.verUniversidadToolStripMenuItem.Text = "Ver Universidad";
            this.verUniversidadToolStripMenuItem.Click += new System.EventHandler(this.verUniversidadToolStripMenuItem_Click);
            // 
            // inscripcionesToolStripMenuItem
            // 
            this.inscripcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inscribirEstudianteToolStripMenuItem,
            this.verInscripcionesToolStripMenuItem});
            this.inscripcionesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscripcionesToolStripMenuItem.Name = "inscripcionesToolStripMenuItem";
            this.inscripcionesToolStripMenuItem.Size = new System.Drawing.Size(95, 21);
            this.inscripcionesToolStripMenuItem.Text = "&Inscripciones";
            this.inscripcionesToolStripMenuItem.Click += new System.EventHandler(this.inscripcionesToolStripMenuItem_Click);
            // 
            // inscribirEstudianteToolStripMenuItem
            // 
            this.inscribirEstudianteToolStripMenuItem.Name = "inscribirEstudianteToolStripMenuItem";
            this.inscribirEstudianteToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.inscribirEstudianteToolStripMenuItem.Text = "Inscribir estudiante";
            this.inscribirEstudianteToolStripMenuItem.Click += new System.EventHandler(this.inscribirEstudianteToolStripMenuItem_Click);
            // 
            // verInscripcionesToolStripMenuItem
            // 
            this.verInscripcionesToolStripMenuItem.Name = "verInscripcionesToolStripMenuItem";
            this.verInscripcionesToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.verInscripcionesToolStripMenuItem.Text = "Ver inscripciones";
            this.verInscripcionesToolStripMenuItem.Click += new System.EventHandler(this.verInscripcionesToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMenu";
            this.Text = "MDI";
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem universidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verUniversidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscribirEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInscripcionesToolStripMenuItem;
    }
}



