
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
    
public partial class VehicleFuels
{

    public int Id { get; set; }

    public Nullable<int> TypeFuelId { get; set; }

    public Nullable<double> Amount { get; set; }

    public Nullable<double> LiterFuel { get; set; }

    public Nullable<System.DateTime> FuelDate { get; set; }

    public Nullable<int> VehicleId { get; set; }



    public virtual TypeFuels TypeFuels { get; set; }

    public virtual Vehicles Vehicles { get; set; }

}

}
