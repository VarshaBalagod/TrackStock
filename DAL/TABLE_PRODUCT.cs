//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockTraker.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TABLE_PRODUCT
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int StockAmount { get; set; }
        public int Price { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime DateDeleted { get; set; }
    }
}
