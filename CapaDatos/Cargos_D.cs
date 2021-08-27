using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class Cargos_D
    {
       // RecursosHumanosEntities db = new RecursosHumanosEntities();

        public void InsertarCargo(Cargo cag)
        {
            using (var db = new RecursosHumanosEntities())
            {
                db.Cargos.Add(cag);
                db.SaveChanges();
            }
        }

        public List<Cargo> ListaCargo()
        {   using (var db = new RecursosHumanosEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Cargos.ToList();
            }
        }

        public Cargo GetCargo(int id)
        {
            using (var db = new RecursosHumanosEntities())
            {
                return db.Cargos.Find(id);
            }
        }

        public void Editar(Cargo cag)
        {
            using (var db = new RecursosHumanosEntities())
            {
                var d = db.Cargos.Find(cag.Id);
                d.Cargo1 = cag.Cargo1;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new RecursosHumanosEntities())
            {
                var cag = db.Cargos.Find(id);
                db.Cargos.Remove(cag);
                db.SaveChanges();
            }
        }      
    }
}
