//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MedidoresModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lectura
    {
        public int idLectura { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan hora { get; set; }
        public decimal valorConsumo { get; set; }
        public int numeroSerie { get; set; }
    
        public virtual Medidor Medidor { get; set; }
    }
}
