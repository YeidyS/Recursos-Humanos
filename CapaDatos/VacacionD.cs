using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
   public class VacacionD
    {
        public void InsertarVacacion(Vacacione vac)
        {
            using (var db = new RecursosHumanosEntities())
            {
                db.Vacaciones.Add(vac);
                db.SaveChanges();
            }
        }

        public List<Vacacione> ListarVac()
        {
            using (var db = new RecursosHumanosEntities())
            {
                //db.Configuration.LazyLoadingEnabled = false;
                return db.Vacaciones.ToList();
            }
        }
    }
}
