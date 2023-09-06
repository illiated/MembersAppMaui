namespace MembersApp.Models
{
    public class Member
    {
        public string Constituency { get; set; }
        public int Id { get; set; }
        public string NameAddressAs { get; set; }
        public string NameDisplayAs { get; set; }
        public Color PartyColour { get; set; }
        public string PartyName { get; set; }
        public string TeaserText { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}
