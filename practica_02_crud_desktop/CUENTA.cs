//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace practica_02_crud_desktop
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUENTA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUENTA()
        {
            this.TRANSACCION = new HashSet<TRANSACCION>();
        }
    
        public long CUENTA_ID { get; set; }
        public Nullable<int> TCUENTA_ID { get; set; }
        public Nullable<long> SUCURSAL_ID { get; set; }
        public Nullable<long> PERSONA_ID { get; set; }
        public Nullable<long> USU_PERSONA_ID { get; set; }
        public string CUENTA_NUMERO { get; set; }
        public System.DateTime CUENTA_FECHAEMISION { get; set; }
        public bool CUENTA_ESTADO { get; set; }
        public decimal CUENTA_SALDO { get; set; }
    
        public virtual SUCURSAL SUCURSAL { get; set; }
        public virtual SOCIO SOCIO { get; set; }
        public virtual TIPO_CUENTA TIPO_CUENTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANSACCION> TRANSACCION { get; set; }
    }
}