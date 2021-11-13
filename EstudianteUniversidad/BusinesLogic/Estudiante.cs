using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudianteUniversidad.DataAccess;
using System.Data.Objects.SqlClient;
using System.Windows.Forms;

namespace EstudianteUniversidad.BusinesLogic
{
    public class Estudiante
    {
        private BDUniversidadEntities conn; //Declarar objeto de tipo contexto (conexion)
        public int PK_Estudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNac { get; set; }
        public string sexo { get; set; }
        public bool Active { get; set; }

        public Estudiante() // Inicializar variables en constructor
        {
            this.Nombre = string.Empty;
            this.Apellido = string.Empty;
            this.sexo = string.Empty;
            this.Active = false;
            conn = new BDUniversidadEntities();
        }


        public bool AgregarEstudiante()
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    DataAccess.Estudiante e = new DataAccess.Estudiante();
                    e.Nombre = this.Nombre;
                    e.Apellido = this.Apellido;
                    e.sexo = this.sexo;
                    e.FechaDeNac = this.FechaDeNac;
                    e.Active = true;

                    conn.Estudiante.Add(e);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                   MessageBox.Show(Ex.Message.ToString(), "Ups..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        public bool EliminarEstudiante()
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    DataAccess.Estudiante t = new DataAccess.Estudiante();
                    DataAccess.Estudiante e = new DataAccess.Estudiante();
                    e.PK_Estudiante = this.PK_Estudiante;
                    e.Nombre = this.Nombre;
                    e.Apellido = this.Apellido;
                    e.sexo = this.sexo;
                    e.FechaDeNac = this.FechaDeNac;
                    e.Active = this.Active;

                    conn.Estudiante.Attach(e);
                    conn.Entry(e).Property(x => x.Active).IsModified = true;
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
        }

        public bool ActualizarEstudiante()
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    DataAccess.Estudiante e = new DataAccess.Estudiante();
                    e.PK_Estudiante = this.PK_Estudiante;
                    e.Nombre = this.Nombre;
                    e.Apellido = this.Apellido;
                    e.sexo = this.sexo;
                    e.FechaDeNac = this.FechaDeNac;
                    e.Active = true; ;

                    conn.Estudiante.Attach(e);
                    conn.Entry(e).State = System.Data.EntityState.Modified;
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }

            }
        }

        public void listadoEstudiante(DataGridView data)
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    var query = (from m in conn.Estudiante
                                 where m.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar usando el result de la query
                                     PK_Estudiante = m.PK_Estudiante,
                                     Nombre = m.Nombre,
                                     Apellido = m.Apellido,
                                     FechaNac = m.FechaDeNac,
                                     Sexo = m.sexo
                                 }
                                 ).ToList(); //Convetir de var no tipado [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }

            }
        }

        public void listadoEstudianteCbo(ComboBox cbo)
        {
            using (conn = new BDUniversidadEntities())
            {
                try
                {
                    var query = (from m in conn.Estudiante
                                 where m.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_Estudiante = m.PK_Estudiante,
                                     nDisplayMember = (SqlFunctions.StringConvert((double)m.PK_Estudiante).Trim()) + " - " + m.Nombre + " " + m.Apellido
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    cbo.DataSource = query;
                    cbo.DisplayMember = "nDisplayMember"; //Nombre de la columna en el modelo
                    cbo.ValueMember = "PK_Estudiante";
                }
                catch (Exception Ex)
                {

                }

            }
        }

  
    }
}





