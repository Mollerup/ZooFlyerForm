using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZooFlyerWebService.Models
{
    public partial class Day
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Day()
        {
            OpeningHours = new HashSet<OpeningHour>();
        }

        public int Id { get; set; }

        [Column("Day")]
        [Required]
        [StringLength(10)]
        public string Day1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OpeningHour> OpeningHours { get; set; }
    }
}
