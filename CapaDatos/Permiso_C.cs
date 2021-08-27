using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class Permiso_C
    {
        public void InsertarPermiso(Permiso perm)
        {
            using (var db = new RecursosHumanosEntities())
            {
                db.Permisoes.Add(perm);
                db.SaveChanges();
            }
        }

        public List<Permiso> ListarPerm()
        {
            using (var db = new RecursosHumanosEntities())
            {
                //db.Configuration.LazyLoadingEnabled = false;
                return db.Permisoes.ToList();
            }
        }
    }
}
