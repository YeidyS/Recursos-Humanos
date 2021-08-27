using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Empleados_D
    {
        RecursosHumanosEntities db = new RecursosHumanosEntities();

        public void InsertarEmpleado(Empleado empl)
        {
          
                db.Empleados.Add(empl);
                db.SaveChanges();
        }

        public List<ListaEmp_Result> ListaEmpleado()
        {
            using (var db = new RecursosHumanosEntities())
            {
                var dataform1 = db.ListaEmp().ToList();
                return dataform1;
            }
        }
        public List<Empleado> ListarEmpl()
        {
            using (var db = new RecursosHumanosEntities())
            {
                db.Configuration.LazyLoadingEnabled = false;
                return db.Empleados.ToList();
            }
        }

       
        public void Editar(Empleado empl)
        {
            using (var db = new RecursosHumanosEntities())
            {
                var d = db.Empleados.Find(empl.Id);
                d.CodEmpl = empl.CodEmpl;
                d.Nombre = empl.Nombre;
                d.Apellido = empl.Apellido;
                d.Telefono = empl.Telefono;
                d.Departamento = empl.Departamento;
                d.Cargo1 = empl.Cargo1;
                d.FechaIngreso = empl.FechaIngreso;
                d.Salario = empl.Salario;
                d.Estatus = empl.Estatus;
                db.SaveChanges();
            }
        }

        public Empleado GetEmpleado(int id)
        {
            using (var db = new RecursosHumanosEntities())
            {
                return db.Empleados.Find(id);
            }
        }

        public EmpleadoCE ObtenerEmpleado(int id)
        {
            string sql = @"select e.CodEmpl,e.Nombre,e.Apellido,e.Telefono,d.Nombre as 'Departamento', c.Cargo as 'Cargo', 
e.FechaIngreso, e.Salario, e.Estatus
from Empleados e inner join Departamentos d on e.Departamento = d.Id inner join Cargos c on e.Cargo = c.Id
where e.Id = @Id";

            using (var db = new RecursosHumanosEntities())
            {
                return db.Database.SqlQuery<EmpleadoCE>(sql,
                    new SqlParameter("@Id", id)).FirstOrDefault();
            }
        }

        public void Eliminar(int id)
        {
            using (var db = new RecursosHumanosEntities())
            {
                var empl = db.Empleados.Find(id);
                db.Empleados.Remove(empl);
                db.SaveChanges();
            }
        }
    }
}
