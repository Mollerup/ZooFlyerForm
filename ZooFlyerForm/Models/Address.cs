using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ZooFlyerForm.Models
{
    public partial class Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Address()
        {
            Flyers = new HashSet<Flyer>();
        }

        public int Id { get; set; }

        public int Zipcode { get; set; }

        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        public virtual City City { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flyer> Flyers { get; set; }
    }
}
