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
    
    public partial class Illustration
    {
    	public Illustration()
    	{
    		this.ProductModelIllustrations = new HashSet<ProductModelIllustration>();
    	}
    
    	[Key]
		public int IllustrationID { get; set; }
    	public string Diagram { get; set; }
    	public System.DateTime ModifiedDate { get; set; }
    
    	public virtual ICollection<ProductModelIllustration> ProductModelIllustrations { get; set; }
    }
}
