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
    
    public partial class TopicMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TopicMaster()
        {
            this.ViewStatus = new HashSet<ViewStatu>();
        }
    
        public string TopicName { get; set; }
        public int SubjectId { get; set; }
        public string ChapterName { get; set; }
        public System.DateTime LastUpdateOn { get; set; }
        public string ContentUrl { get; set; }
    
        public virtual ChapterMaster ChapterMaster { get; set; }
        public virtual SubjectMaster SubjectMaster { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViewStatu> ViewStatus { get; set; }
    }
}
