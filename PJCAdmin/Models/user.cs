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
    
    public partial class user
    {
        public user()
        {
            this.usertasks = new HashSet<usertask>();
            this.usertaskprompts = new HashSet<usertaskprompt>();
            this.jobs = new HashSet<job>();
            this.user1 = new HashSet<user>();
            this.users = new HashSet<user>();
        }
    
        public int userID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string homePhone { get; set; }
        public string mobilePhone { get; set; }
        public string workPhone { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int userTypeID { get; set; }
    
        public virtual usertype usertype { get; set; }
        public virtual ICollection<usertask> usertasks { get; set; }
        public virtual ICollection<usertaskprompt> usertaskprompts { get; set; }
        public virtual ICollection<job> jobs { get; set; }
        public virtual ICollection<user> user1 { get; set; }
        public virtual ICollection<user> users { get; set; }
    }
}
