//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFStatistics3
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblOrder
    {
        public int OrderId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> ProductId { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
    
        public virtual TblCustomer TblCustomer { get; set; }
        public virtual TblProduct TblProduct { get; set; }
    }
}
