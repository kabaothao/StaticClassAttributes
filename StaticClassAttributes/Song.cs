using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassAttributes
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;

        //below i'm going to create a static attribute:
        public static int songCount = 0 ; //this will tell us how many songs objects have been created. 



        public Song(string aTitle, string aArtist, int aDuration) //again we have this constructor which allows the caller to create the object right up front. 
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++; //every time a Song is called a songCount is going to get incremented. 
            /*
             So every time we create a song, in other words after all this code in the constructor, I'm just going to increment the song count. So let's add songCount ++;
             */


        }
        //you can create a method 
        public int getSongCount()
        {
            return Song.songCount;
        }



    }


}

/*
 What is Static Attribute?
Static attribute is basically a special type of attribute in class which is shared by all of the obkects and all the instances of the class. So a
static attribute is technically an attribute that is contained on the class itself, instead of on the individual objects of that class. And I'm going to sort of explain to you how
this works. Over here in my program, I actually created a class, and its called song. And this class basically just models a song in our program.
So its kind of like a blueprint.

So static attribute is technically an attribute that is contained on the class itself, instead of on the individual objects of that class. 

line 11-13 are normal attributes, but here is another attribute called a static attribute.
static attribute - is an attribute that isnt unique to each one of the objects. In other words, a static attribute is an attribute about the class. So this title attribute, like I said, its different for each of the objects.
So holiday.title and cashmere.title, those are different values, but a static attribute is going to be the same across all of the objects of a class. so it is basically an attribute that we would say it is about the class.


anytime a song object gets created, this method gets called its a guarantee. 

*/
