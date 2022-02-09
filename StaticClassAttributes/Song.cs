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
    }

    public Song(string aTitle, string aArtist, int aDuration) //again we have this constructor which allows the caller to create the object right up front. 
    {
        title = aTitle;
        artist = aArtist;
        duration = aDuration;

    }


}

/*
 What is Static Attribute?
Static attribute is basically a special type of attribute in class which is shared by all of the obkects and all the instances of the class. So a
static attribute is technically an attribute that is contained on the class itself, instead of on the individual objects of that class. And I'm going to sort of explain to you how
this works. Over hee in my program, I actually created a class, and its called song. And this class basically just models a song in our program.
So its kind of like a blueprint.

So static attribute is technically an attribute that is contained on the class itself, instead of on the individual objects of that class. 


*/
