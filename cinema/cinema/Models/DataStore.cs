namespace cinema.Models
{
    using System.Collections.Generic;

    public static class DataStore
    {
        public static List<Guest> Guests { get; set; } = new List<Guest>();
        public static List<Cinema> Cinemas { get; set; } = new List<Cinema>
        {
            new Cinema("SALA NORD"),
            new Cinema("SALA EST"),
            new Cinema("SALA SUD")
        };
    }
}
