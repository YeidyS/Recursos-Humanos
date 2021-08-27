using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public class VacacionN
    {
        VacacionD ejecutorV = new VacacionD();

        public void GuardarV(Vacacione vac)
        {
            ejecutorV.InsertarVacacion(vac);
        }

        public List<Vacacione> MostrarDatosV()
        {
            return ejecutorV.ListarVac().ToList();
        }
    }
}
