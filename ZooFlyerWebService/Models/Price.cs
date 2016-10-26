using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooFlyerWebService.Models
{
    public partial class Price
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Price()
        {
            Flyers = new HashSet<Flyer>();
        }

        public int Id { get; set; }

        [Column("Price")]
        public int Price1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flyer> Flyers { get; set; }
    }
}
