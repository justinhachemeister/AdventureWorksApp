//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adventureworks.Domain5
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class PurchaseOrderHeader
    {
    	public PurchaseOrderHeader()
    	{
    		this.PurchaseOrderDetails = new HashSet<PurchaseOrderDetail>();
    	}
    
    	[Key]
		public int PurchaseOrderID { get; set; }
    	public byte RevisionNumber { get; set; }
    	public byte Status { get; set; }
    	public int EmployeeID { get; set; }
    	public int VendorID { get; set; }
    	public int ShipMethodID { get; set; }
    	public System.DateTime OrderDate { get; set; }
    	public Nullable<System.DateTime> ShipDate { get; set; }
    	public decimal SubTotal { get; set; }
    	public decimal TaxAmt { get; set; }
    	public decimal Freight { get; set; }
    	public decimal TotalDue { get; set; }
    	public System.DateTime ModifiedDate { get; set; }
    
    	public virtual Employee Employee { get; set; }
    	public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    	public virtual ShipMethod ShipMethod { get; set; }
    	public virtual Vendor Vendor { get; set; }
    }
}
