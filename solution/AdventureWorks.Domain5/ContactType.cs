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
    
    public partial class ContactType
    {
    	public ContactType()
    	{
    		this.BusinessEntityContacts = new HashSet<BusinessEntityContact>();
    	}
    
    	[Key]
		public int ContactTypeID { get; set; }
    	public string Name { get; set; }
    	public System.DateTime ModifiedDate { get; set; }
    
    	public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
    }
}
