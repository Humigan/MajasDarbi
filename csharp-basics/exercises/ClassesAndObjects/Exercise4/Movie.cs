using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Movie
    {
        string title;
        string studio;
        string rating;

        public Movie(string title, string studio, string rating)
        {
            this.title = title;
            this.studio = studio;
            this.rating = rating;
        }

        public Movie(string title, string studio)
        {
            this.title = title;
            this.studio = studio;
            rating = "PG";
        }

        public Movie GetPG(Movie[] all) 
        {
            int count = 0;

            for (int i = 0; i < all.Length; i++)
            {
                if (all[i].rating == "PG")
                {
                    count++;
                }  
            }

            Movie [] MyArr = new Movie[count];
            int j = 0;

            for (int i = 0; i < all.Length; i++)
            {
                if (all[i].rating == "PG")
                {
                    MyArr[j] = all[i];
                    j++;
                }
            }

            for (int i = 0; i < MyArr.Length; i++)
            {
                Console.WriteLine(MyArr[i].title + " has PG rating");
            }

             return MyArr[count - 1];
        }
    }
}
