using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
   public  class Licencia_C
    {
        public void InsertarLicencia(Licencia linc)
        {
            using (var db = new RecursosHumanosEntities())
            {
                db.Licencias.Add(linc);
                db.SaveChanges();
            }
        }

        public List<Licencia> ListarLinc()
        {
            using (var db = new RecursosHumanosEntities())
            {
                //db.Configuration.LazyLoadingEnabled = false;
                return db.Licencias.ToList();
            }
        }
    }
}
