namespace Domain
{
    public class Teams
    {
        public string City { get; set; }
        public string TeamName { get; set; }
        public string LogoURL { get; set; }
        public virtual Players Players { get; set; }
        public virtual RingHonor RingHonor { get; set; }
    }
}