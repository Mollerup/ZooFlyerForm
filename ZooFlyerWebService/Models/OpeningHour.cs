using System;
using System.Collections.Generic;

namespace ZooFlyerWebService.Models
{
    public partial class OpeningHour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OpeningHour()
        {
            Flyers = new HashSet<Flyer>();
        }

        public int Id { get; set; }

        public int Season { get; set; }

        public int Day { get; set; }

        public TimeSpan Open { get; set; }

        public TimeSpan Close { get; set; }

        public virtual Day Day1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Flyer> Flyers { get; set; }

        public virtual Season Season1 { get; set; }
    }
}
