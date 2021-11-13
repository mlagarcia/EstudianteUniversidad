using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstudianteUniversidad.DataAccess;
using System.Windows.Forms;
using System.Data.Objects.SqlClient;

namespace EstudianteUniversidad.BusinesLogic
{
    public class Universidad
    {
        private BDUniversidadEntities conn;
        public int PK_Universidad { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Ciudad { get; set; }
        public Nullable<int> AnioFundacion { get; set; }
        public bool Active { get; set; }

        public Universidad()
        {
            this.Nombre = string.Empty;
            this.Pais = string.Empty;
            this.Ciudad = string.Empty;
            this.AnioFundacion = 1999;
            this.Active = false;
            conn = new BDUniversidadEntities();
        }
        public bool AgregarUniversidad() // agregar universidad
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    DataAccess.Universidad e = new DataAccess.Universidad();
                    e.Nombre = this.Nombre;
                    e.Pais = this.Pais;
                    e.Ciudad = this.Ciudad;
                    e.AnioFundacion = this.AnioFundacion;
                    e.Active = true;

                    conn.Universidad.Add(e);
                    conn.SaveChanges();

                    return true;
                }
                catch (Exception Ex)
                {
                    return false;
                }
            }
        }
        public bool EliminarUniversidad()//eliminar universidad
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    DataAccess.Universidad t = new DataAccess.Universidad();
                    DataAccess.Universidad e = new DataAccess.Universidad();
                    e.PK_Universidad = this.PK_Universidad;
                    e.Nombre = this.Nombre;
                    e.Pais = this.Pais;
                    e.Ciudad = this.Ciudad;
                    e.AnioFundacion = this.AnioFundacion;
                    e.Active = this.Active;

                    conn.Universidad.Attach(e);
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
        public bool ActualizarUniversidad()
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    DataAccess.Universidad e = new DataAccess.Universidad();
                    e.PK_Universidad = this.PK_Universidad;
                    e.Nombre = this.Nombre;
                    e.Pais = this.Pais;
                    e.Ciudad = this.Ciudad;
                    e.AnioFundacion = this.AnioFundacion;
                    e.Active = true; 

                    conn.Universidad.Attach(e);
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
        public void listadoUniversidad(DataGridView data)
        {
            using (BDUniversidadEntities conn = new BDUniversidadEntities())
            {
                try
                {
                    var query = (from m in conn.Universidad
                                 where m.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar usando el result de la query
                                     PK_Universidad = m.PK_Universidad,
                                     Nombre = m.Nombre,
                                     Pais = m.Pais,
                                     Ciudad = m.Ciudad,
                                     AnioFundacion = m.AnioFundacion
                                 }
                                 ).ToList(); //Convetir de var no tipado [query] a list

                    data.DataSource = query; //Pasar list a DataGridView
                }
                catch (Exception Ex)
                {

                }

            }
        }
        public void listadoUniCbo(ComboBox cbo)
        {
            using (conn = new BDUniversidadEntities())
            {
                try
                {
                    var query = (from m in conn.Universidad
                                 where m.Active == true //Filtar por registros con Active = 1

                                 select new
                                 {   //Parametros a mostrar del result de la query
                                     PK_Universidad = m.PK_Universidad,
                                     nDisplayMember = (SqlFunctions.StringConvert((double)m.PK_Universidad).Trim()) + " - " + m.Nombre
                                 }
                                 ).ToList(); //Convetir de var [query] a list

                    cbo.DataSource = query;
                    cbo.ValueMember = "PK_Universidad";
                    cbo.DisplayMember = "nDisplayMember";
                }
                catch (Exception Ex)
                {

                }
            }

        }

    }
}
   

