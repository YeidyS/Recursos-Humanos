using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public class Cargo_N
    {
        Cargos_D ejecutorC = new Cargos_D();

        public void GuardarCargo(Cargo cag)
        {
            ejecutorC.InsertarCargo(cag);
        }

        public List<Cargo> MostrarDatoC()
        {
            return ejecutorC.ListaCargo().ToList();
        }

        public Cargo GetCargo(int id)
        {
            return ejecutorC.GetCargo(id);
        }

        public void Editar(Cargo cag)
        {
            ejecutorC.Editar(cag);
        }

        public void Eliminar(int id)
        {
            ejecutorC.Eliminar(id);
        }
    }
}
