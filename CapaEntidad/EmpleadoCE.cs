using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidad
{
    public class EmpleadoCE
    {
        public int Id { get; set; }
        public Nullable<int> CodEmpl { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public Nullable<int> Departamento { get; set; }
        public Nullable<int> Cargo { get; set; }
        public Nullable<System.DateTime> FechaIngreso { get; set; }
        public Nullable<decimal> Salario { get; set; }
        public string Estatus { get; set; }
    }
}
