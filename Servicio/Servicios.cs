using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace Servicio
{
    public class Servicios
    {
       static RecursosHumanosEntities contexto = new RecursosHumanosEntities();

        static public List<BuscarEmpleado_Result> BuscarEmpleado(string nombre)
        {
            return contexto.BuscarEmpleado(nombre).ToList();
        }
    }
}