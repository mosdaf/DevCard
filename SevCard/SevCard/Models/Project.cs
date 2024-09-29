namespace SevCard.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public Project(long id, string image, string title, string description, string client)
        {
            Id = id;
            Image = image;
            Title = title;
            Description = description;
            Client = client;
        }
    }
}
