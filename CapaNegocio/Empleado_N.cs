using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class Empleado_N
    {
        Empleados_D ejecutor = new Empleados_D();

        public void GuardarEmpleado(Empleado elemento)
        {
            ejecutor.InsertarEmpleado(elemento);
        }

        public List<ListaEmp_Result> MostrarDatos()
        {
            return ejecutor.ListaEmpleado();
        }

        public List<Empleado> ListarEmpl()
        {
            return ejecutor.ListarEmpl();
        }
        public Empleado GetEmpleado(int id)
        {
            return ejecutor.GetEmpleado(id);
        }


        public void Editar(Empleado empl)
        {
            ejecutor.Editar(empl);
        }

        //public void Editar(Empleado empl)
        //{
        //    throw new NotImplementedException();
        //}

        public EmpleadoCE ObtenerEmpleado(int id)
        {
            return ejecutor.ObtenerEmpleado(id);
        }

        public void Eliminar(int id)
        {
            ejecutor.Eliminar(id);
        }
    }
}
