namespace cinema.Models
{
    public class Cinema
    {
        public string Name { get; set; }
        public int TotalTicketsSold { get; set; }
        public int ReducedTicketsSold { get; set; }
        public int Capacity { get; set; } = 120;

        public Cinema(string name)
        {
            Name = name;
            TotalTicketsSold = 0;
            ReducedTicketsSold = 0;
        }
    }
}
