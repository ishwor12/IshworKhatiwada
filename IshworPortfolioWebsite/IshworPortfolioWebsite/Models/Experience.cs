namespace IshworPortfolioWebsite.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Location { get; set; }
        public string Period { get; set; }
        public List<string> Responsibilities { get; set; }
        public List<string> KeyLearnings { get; set; }
    }
}
