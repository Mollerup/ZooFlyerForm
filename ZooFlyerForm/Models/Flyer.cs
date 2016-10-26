namespace ZooFlyerForm.Models
{
    public partial class Flyer
    {
        public int Id { get; set; }

        public int User { get; set; }

        public int OpeningHours { get; set; }

        public int Price { get; set; }

        public int Address { get; set; }

        public int Pics { get; set; }

        public virtual Address Address1 { get; set; }

        public virtual OpeningHour OpeningHour { get; set; }

        public virtual Image Image { get; set; }

        public virtual Price Price1 { get; set; }

        public virtual User User1 { get; set; }
    }
}
