using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_L10_DataClass
{
    // Access Modifer - Class Keyword - Class Name
    // FIRST STEP - Change internal to Public
    public class Album
    {
        // Fields
        // Data Types - Strings, Ints, Doubles, Bool

        // Public access modifer gives access to EVERYTHING
        // all fields should START with an underscore, _

        public string _title;
        public string _artistName;
        public int _year;
        public string _albumCoverLocation;

        // Constructor - Defines what information is REQUIRED
        // Access Modifer - CLASS NAME - Parenthese - Parameters 

        public Album(string title, string artistName)
        {
            _title = title;
            _artistName = artistName;
        } // Album

        public Album(string title, string artistName, int year)
        {
            _title = title;
            _artistName = artistName;
            _year = year;
        }

        // WHen you make a class with NO constructor, it has a DEFAULT constructor that takes no paremeters
        // The Second you make your OWN constructor, the default constructor is removed


        // A Constructor that takes NO paremeters
        public Album()
        {

        } // Default Constructor



    } // class

} // namespace



// If i am planning on doing math or using > or < symbols, then I will do an int or double
// Else i will keep it a string

// The question IS what do I plan to do with the field



// What makes an album


//* Title
//* Artist Name
//* Year Released
//* Artwork
//* A List of songs

