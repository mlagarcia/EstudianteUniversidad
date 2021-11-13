using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudianteUniversidad.DataAccess;
using System.Windows.Forms;

namespace EstudianteUniversidad.BusinesLogic
{
    public class UniEstudiante
    {
        public int PK_UniversidadEstudiante { get; set; }
        public Nullable<int> FK_Universidad { get; set; }
        public Nullable<int> FK_Estudiante { get; set; }
        public bool Active { get; set; }

        public virtual Estudiante Est { get; set; }
        public virtual Universidad Uni { get; set; }


        public bool InscripcionEst()
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    DataAccess.UniversidadEstudiante u = new DataAccess.UniversidadEstudiante();
                    u.FK_Estudiante = this.Est.PK_Estudiante;
                    u.FK_Universidad = this.Uni.PK_Universidad;
                    u.Active = true;

                    conn.UniversidadEstudiante.Add(u);
                    conn.SaveChanges();
                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
        }

        public void listadoUniEst(DataGridView data)
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    var query = (from m in conn.Estudiante
                                 join ue in conn.UniversidadEstudiante on m.PK_Estudiante equals ue.FK_Estudiante
                                 join u in conn.Universidad on ue.FK_Universidad equals u.PK_Universidad
                                 where ue.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar usando el result de la query
                                     PK_Estudiante = m.PK_Estudiante,
                                     Nombre = m.Nombre,
                                     Apellido = m.Apellido,
                                     Universidad = u.Nombre,
                                     Pais = u.Pais,
                                     Ciudad = u.Ciudad
                                 }
                                 ).ToList(); //Convetir de var no tipado [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }

            }
        }

        public void listadoBuscarPorNombre(DataGridView data, String nNombre)
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    var query = (from m in conn.Estudiante
                                 join ue in conn.UniversidadEstudiante on m.PK_Estudiante equals ue.FK_Estudiante
                                 join u in conn.Universidad on ue.FK_Universidad equals u.PK_Universidad
                                 where ue.Active == true && m.Nombre.Contains(nNombre)

                                 select new
                                 {   //Parametros a mostrar usando el result de la query
                                     PK_Estudiante = m.PK_Estudiante,
                                     Nombre = m.Nombre,
                                     Apellido = m.Apellido,
                                     Universidad = u.Nombre,
                                     Pais = u.Pais,
                                     Ciudad = u.Ciudad
                                 }
                                 ).ToList(); //Convetir de var no tipado [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }

            }
        }
        public void listadoBuscarPorApellido(DataGridView data, String nApellido)
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    var query = (from m in conn.Estudiante
                                 join ue in conn.UniversidadEstudiante on m.PK_Estudiante equals ue.FK_Estudiante
                                 join u in conn.Universidad on ue.FK_Universidad equals u.PK_Universidad
                                 where ue.Active == true && m.Apellido.Contains(nApellido)

                                 select new
                                 {   //Parametros a mostrar usando el result de la query
                                     PK_Estudiante = m.PK_Estudiante,
                                     Nombre = m.Nombre,
                                     Apellido = m.Apellido,
                                     Universidad = u.Nombre,
                                     Pais = u.Pais,
                                     Ciudad = u.Ciudad
                                 }
                                 ).ToList(); //Convetir de var no tipado [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }

            }
        }

        public void listadoBusquedaPorUniversidad(DataGridView data, String nUniversidad)
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    var query = (from m in conn.Estudiante
                                 join ue in conn.UniversidadEstudiante on m.PK_Estudiante equals ue.FK_Estudiante
                                 join u in conn.Universidad on ue.FK_Universidad equals u.PK_Universidad
                                 where ue.Active == true && u.Nombre.Contains(nUniversidad)

                                 select new
                                 {   //Parametros a mostrar usando el result de la query
                                     PK_Estudiante = m.PK_Estudiante,
                                     Nombre = m.Nombre,
                                     Apellido = m.Apellido,
                                     Universidad = u.Nombre,
                                     Pais = u.Pais,
                                     Ciudad = u.Ciudad
                                 }
                                 ).ToList(); //Convetir de var no tipado [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }

            }
        }
    }
}
