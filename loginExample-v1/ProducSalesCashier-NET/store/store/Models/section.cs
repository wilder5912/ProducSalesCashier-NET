//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace store.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public section()
        {
            this.subsection = new HashSet<subsection>();
        }
    
        public decimal section_id { get; set; }
        public Nullable<decimal> group_id { get; set; }
        public string name_section { get; set; }
        public Nullable<bool> is_delete_section { get; set; }
    
        public virtual groupproduct groupproduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<subsection> subsection { get; set; }
    }
}
