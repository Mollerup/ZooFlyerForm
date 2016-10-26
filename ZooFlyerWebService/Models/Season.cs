using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooFlyerWebService.Models
{
    public partial class Season
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Season()
        {
            OpeningHours = new HashSet<OpeningHour>();
        }

        public int Id { get; set; }

        [Column("Season")]
        [Required]
        [StringLength(20)]
        public string Season1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningHour> OpeningHours { get; set; }
    }
}
