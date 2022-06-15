//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoppingCart
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal ListPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> MarkId { get; set; }
        public Nullable<decimal> Width { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string Color { get; set; }
        public string Picture { get; set; }
        public bool Enabled { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Mark Mark { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}