using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaDatos
{
    public class Departamento_D
    {
       // RecursosHumanosEntities db = new RecursosHumanosEntities();

        public void InsertarDepartamento(Departamento dept)
        {
            using (var db = new RecursosHumanosEntities())
            {
                db.Departamentos.Add(dept);
                db.SaveChanges();
            }
        }

        public List<Departamento> ListaDepartamento()
        {
            using (var db = new RecursosHumanosEntities()) 
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Departamentos.ToList();
            }
        }

        public Departamento GetDepartamento(int id)
        {
            using (var db = new RecursosHumanosEntities())
            {
                return db.Departamentos.Find(id);
            }
        }

        public void Editar(Departamento dept)
        {
            using (var db = new RecursosHumanosEntities())
            {
                var d = db.Departamentos.Find(dept.Id);
                d.Nombre = dept.Nombre;
                d.CodDept = dept.CodDept;
                db.SaveChanges();
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (var db = new RecursosHumanosEntities())
                {
                    var dpto = db.Departamentos.Find(id);
                    db.Departamentos.Remove(dpto);
                    db.SaveChanges();
                }
            }catch(Exception error)
            {
                Console.WriteLine("No puede borrar este departamento");
            }
        }

        public List<Departamento> ListarDept()
        {
            using (var db = new RecursosHumanosEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Departamentos.ToList();
            }
        }
    }
}