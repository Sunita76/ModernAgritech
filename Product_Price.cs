//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoGreen
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Price
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Pack { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
