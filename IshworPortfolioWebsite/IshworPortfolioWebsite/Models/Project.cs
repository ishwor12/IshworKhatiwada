namespace IshworPortfolioWebsite.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public string Architecture { get; set; }
        public List<string> Technologies { get; set; }
        public List<string> Contributions { get; set; }
    }
}
