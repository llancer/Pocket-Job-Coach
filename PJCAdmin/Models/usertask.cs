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
    
    public partial class usertask
    {
        public int userID { get; set; }
        public int taskID { get; set; }
        public Nullable<System.DateTime> startTime { get; set; }
        public Nullable<System.DateTime> endTime { get; set; }
        public string daysOfWeek { get; set; }
        public short sendNotification { get; set; }
        public string feedbackMessage { get; set; }
    
        public virtual task task { get; set; }
        public virtual user user { get; set; }
    }
}
