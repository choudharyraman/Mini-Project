//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ViewStatu
    {
        public int ID { get; set; }
        public string LearnerEmailId { get; set; }
        public int SubjectId { get; set; }
        public string ChapterName { get; set; }
        public string TopicName { get; set; }
        public System.DateTime ViewTime { get; set; }
        public string Comments { get; set; }
    
        public virtual ChapterMaster ChapterMaster { get; set; }
        public virtual LearnerProfile LearnerProfile { get; set; }
        public virtual SubjectMaster SubjectMaster { get; set; }
        public virtual TopicMaster TopicMaster { get; set; }
    }
}