//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SearchApi
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblProduct
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblProduct()
        {
            this.tblPricings = new HashSet<tblPricing>();
        }
    
        public int product_id { get; set; }
        public string name { get; set; }
        public string manufacturer { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public Nullable<int> quantity_in_stock { get; set; }
        public Nullable<int> min_quantity_to_order { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPricing> tblPricings { get; set; }
    }
}
