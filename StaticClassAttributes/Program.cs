using System;

namespace StaticClassAttributes
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200); //every time is I say, new Song, this is me calling that constructor on line 20-25
            Console.WriteLine(Song.songCount); 
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.getSongCount());


            //Console.WriteLine(holiday.artist); 
            //actually you can replace from holiday to Song/also you can replace from artist to songCount
            //
            //Console.WriteLine(Song.songCount);

            //Console.WriteLine(kashmir.artist);

            Console.ReadLine();
        }


    }



}

/*
 line 10 and12 - so this static attribute is telling us information not about the specific objects themselves, but about the class in general.
So I can figure out how many objects have been created of the song class.. How many instances of the song class have been created in my program, but that's not a piece of information that 
is going to be specific to the holiday object or to the cashmere object, that is a piece of information that's going to be specific to the class itself. 

You can create as many as you want for static attribute. They're really useful.


overall there are 2 ways to create static attributes
1. You can just create a static attribute and access it using like a song.songcount
OR
2. you cuold create a getter mthod like get getSongCount(), and then the individual objects could access that. 
 */