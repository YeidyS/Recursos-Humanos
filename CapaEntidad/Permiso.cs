//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidad
{
    using System;
    using System.Collections.Generic;
    
    public partial class Permiso
    {
        public int Id { get; set; }
        public string Empleado { get; set; }
        public Nullable<System.DateTime> Desde { get; set; }
        public Nullable<System.DateTime> Hasta { get; set; }
        public string Comentario { get; set; }
    }
}
