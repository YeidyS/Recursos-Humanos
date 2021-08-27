using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
   public  class Permisos_N
    {
        Permiso_C ejecutorP = new Permiso_C();

        public void GuardarP(Permiso perm)
        {
            ejecutorP.InsertarPermiso(perm);
        }

        public List<Permiso> MostrarDatosP()
        {
            return ejecutorP.ListarPerm().ToList();
        }
    }
}
