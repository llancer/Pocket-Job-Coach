//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PJCAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class job
    {
        public job()
        {
            this.tasks = new HashSet<task>();
            this.users = new HashSet<user>();
        }
    
        public int jobID { get; set; }
        public string jobTitle { get; set; }
    
        public virtual ICollection<task> tasks { get; set; }
        public virtual ICollection<user> users { get; set; }
    }
}
