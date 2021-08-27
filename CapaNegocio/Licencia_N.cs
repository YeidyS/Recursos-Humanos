using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class Licencia_N
    {
        Licencia_C ejecutorL = new Licencia_C();

        public void GuardarL(Licencia linc)
        {
            ejecutorL.InsertarLicencia(linc);
        }

        public List<Licencia> MostrarDatosL()
        {
            return ejecutorL.ListarLinc().ToList();
        }
    }
}
