//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI_Farma.pe.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LABORATORIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LABORATORIO()
        {
            this.LABORATORIO_MEDICAMENTO = new HashSet<LABORATORIO_MEDICAMENTO>();
        }
    
        public int ID_LAB { get; set; }
        public string NOM_LAB { get; set; }
        public string RSO_LAB { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LABORATORIO_MEDICAMENTO> LABORATORIO_MEDICAMENTO { get; set; }
    }
}
