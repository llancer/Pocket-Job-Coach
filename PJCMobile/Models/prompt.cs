//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PJCMobile.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class prompt
    {
        public prompt()
        {
            this.usertaskprompts = new HashSet<usertaskprompt>();
        }
    
        public int promptID { get; set; }
        public int typeID { get; set; }
        public int taskID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    
        public virtual task task { get; set; }
        public virtual prompttype prompttype { get; set; }
        public virtual ICollection<usertaskprompt> usertaskprompts { get; set; }
    }
}
