//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrushWeighProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class PricesByClient
    {
        public int Id { get; set; }
        public double Price { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
