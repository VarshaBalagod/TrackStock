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
    
    public partial class TABLE_SALES
    {
        public int SalesID { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int CategoryID { get; set; }
        public int ProductSalesAmount { get; set; }
        public int ProductSalesPrice { get; set; }
        public System.DateTime DateSales { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime DateDeleted { get; set; }
    }
}
