using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettersAndSetters
{
    internal class Movie
    {   //public means these can be access by anyone. any other codes can access to these attributes. public means its open to the world. 
        public string title;
        public string director;
        private string rating;
        //private string rating; 
        //what this means is that only code inside of this movie class is going to be able to access the rating. so only code that is contained inside of these
        //curly brackets over here in this out of this movie class is going to be able to access this 


        public Movie(string aTitle, string aDirector, string aRating) //here I created this constructor where I basically pass in a title, a director, a Rating
                                                                      //and assigned those values.
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; //now this means we're going to set the rating through this setter down here from line 28-46. So this Rating is now calling the Rating below.
        }

        //you need to define two things
        public string Rating
        {
            get { return rating; } //getter is going to allow us to get the rating attribute.
                                   //setter is going to allow us to set the rating. 
                                   //in order to set the rating, we have to go through this if statement. So they can try to pass in whatever rating they want.
                                   //But if its not equal to G, PG, PG-13, etc, then its just going to get set = to not rating (NR). 
                                   //So the reason why we need this getter and setter is because we made line 13 private.
            set { 
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                    {
                    rating = value;

                }
                else
                {
                    rating = "NR"; //if its not G. PG, PG-13, R, and NR, then its going to set the rating to NR.
                }
            }
        }

    }
}

/*
What is this class Movie for and why?
Its basically modeling a movie inside of our program. So this is sort of like a template for the movie data type. 
So every movie is going to have a title, a director, a Rating.

 */
