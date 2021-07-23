using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            var Casino = new Movie("Casino Royale", "Eon Productions", "PG13");
            var Glass = new Movie("Glass", "Buena Vista International", "PG13");
            var Spider = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures", "PG");
            Movie[] all = new Movie[3];
            all[0] = Casino;
            all[1] = Glass;
            all[2] = Spider;
            
            Casino.GetPG(all);
        }
    }
}
