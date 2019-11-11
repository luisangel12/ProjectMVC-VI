
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
    
public partial class Projects
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Projects()
    {

        this.Artifacts = new HashSet<Artifacts>();

        this.UserProjects = new HashSet<UserProjects>();

        this.Tasks = new HashSet<Tasks>();

    }


    public int Id { get; set; }

    public string Title { get; set; }

    public string Details { get; set; }

    public Nullable<System.DateTime> ExpectedCompletionDate { get; set; }

    public Nullable<int> TenantId { get; set; }

    public Nullable<System.DateTime> CreatedAt { get; set; }

    public Nullable<System.DateTime> UpdatedAt { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Artifacts> Artifacts { get; set; }

    public virtual Tenants Tenants { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<UserProjects> UserProjects { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Tasks> Tasks { get; set; }

}

}
