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
    
    public partial class article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public article()
        {
            this.articledetail = new HashSet<articledetail>();
            this.articlerelational = new HashSet<articlerelational>();
            this.comment = new HashSet<comment>();
            this.descriptionarticle = new HashSet<descriptionarticle>();
            this.imagearticle = new HashSet<imagearticle>();
            this.information = new HashSet<information>();
            this.listproduct = new HashSet<listproduct>();
            this.reviewarticle = new HashSet<reviewarticle>();
            this.stockarticle = new HashSet<stockarticle>();
        }
    
        public decimal article_id { get; set; }
        public string name_ar { get; set; }
        public string codigo_ar { get; set; }
        public Nullable<double> precy_ar { get; set; }
        public string detail_ar { get; set; }
        public string image_main_ar { get; set; }
        public Nullable<double> per_discount_ar { get; set; }
        public Nullable<bool> is_discount_ar { get; set; }
        public Nullable<bool> is_delete_ar { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<articledetail> articledetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<articlerelational> articlerelational { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comment> comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<descriptionarticle> descriptionarticle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<imagearticle> imagearticle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<information> information { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<listproduct> listproduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reviewarticle> reviewarticle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<stockarticle> stockarticle { get; set; }
    }
}
