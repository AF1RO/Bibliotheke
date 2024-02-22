namespace Bibliotheke.Models
{
    public class Books
    {
        public int id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string description { get; set; }
        public DateTime published { get; set; }
        public string status { get; set; }
    }
}
