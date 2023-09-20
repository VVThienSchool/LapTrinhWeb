namespace MyWebApp.Models
{
    public class MenuItem
    {
        public MenuItem(int id, string name, string link)
        {
            Id = id;
            Name = name;
            Link = link;
        }

        public int Id { get; set; }//Item id
        public string Name { get; set; } //Item name
        public string Link { get; set; } //Item labe

    }
}
