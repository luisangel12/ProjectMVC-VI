//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AuthoritiesTransit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuthoritiesTransit()
        {
            this.VehicleGeneralInformations = new HashSet<VehicleGeneralInformation>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<bool> Active { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VehicleGeneralInformation> VehicleGeneralInformations { get; set; }
    }
}
