//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bloggsystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Entry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entry()
        {
            this.Comments = new HashSet<Comment>();
        }
    
        public int entryID { get; set; }
        public string title { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public string keywords { get; set; }
        public string description { get; set; }
        public string entry1 { get; set; }
        public int categoryID { get; set; }
        public int userID { get; set; }
    
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual User User { get; set; }
    }
}
