using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public class Departamento_N
    {
        Departamento_D ejecutorD = new Departamento_D();

        public void GuardarDepartamento(Departamento dept)
        {
            ejecutorD.InsertarDepartamento(dept);
        }

        public List<Departamento> MostrarDatosD()
        {
            return ejecutorD.ListaDepartamento().ToList();
        }

        public List<Departamento> ListarDept()
        {
            return ejecutorD.ListarDept().ToList();
        }

        public Departamento GetDepartamento(int id)
        {
            return ejecutorD.GetDepartamento(id);
        }

        public void Editar(Departamento dept)
        {
            ejecutorD.Editar(dept);
        }

        public void Eliminar(int id)
        {
            ejecutorD.Eliminar(id);
        }
    }
}
