namespace GettersAndSetters // Note: actual namespace depends on the project name.
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog"); //if you update PG-13 to Dog then you're going to get an invalid value which will be NR. thats because we have to gp through the setter.
            Movie shref = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating); //so this is the first step to enforce ratings  we need to make the rating field private.
            //avengers.rating = "Dog"; //this is going to yell at me because this is aprivate attribute. so its not going to let me do that. so that's the point of the setters.


            //Example:
            shref.Rating = "Dog";
            Console.WriteLine(shref.Rating); 

            Console.ReadLine();


            //G, PG, PG-13, R, NR lets say these are all the valid ratings that we can have for a movie.
            //Also lets say we want to enforce these rules inside of this movie class. So we want all movies in our programs to only be able to have one of these ratings, and it can't have a rating, other than the ones that i specificed down here. 
            //So how do we enforce that? 

        }
    }
}


/*
 Topic: Getters and Setters 
What is Getters and Setters?
Getters and Setters are basically two types of methods that we can define inside of our c# classes, which will essentially control the access that people have to the 
attributes of the classes. And essentially, what this does is it kind of makes your classes more secure. So it kind of allows you to define like, what data is valid for specific attributes
and what data is invalid. And really getters and setters are extremely useful. And there's a lot of different scenarios where you want to use them. 

 */


