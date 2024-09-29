namespace SevCard.Models
{
    public class Article
    {
        public long Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Article(long id, string image, string title, string description)
        {
            Id = id;
            Image = image;
            Title = title;
            Description = description;
        }
    }
}
