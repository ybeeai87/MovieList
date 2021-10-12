using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieList
{
    class Movie
    {
        //properties
        private string title;
        public string GetTitle()
        {
            return title;
        }
        private string category;
        public string GetCategory()
        {
            return category;
        }
        //constructor
        public Movie(string Title, string Category)
        {
            title = Title;
            category = Category;
        }

    }
}
