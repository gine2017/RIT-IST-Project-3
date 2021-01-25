using System;

/*
 View models differ from domain models in that view models only
contain the data (represented by properties) that you want to use on your view.

TO HELP ME WRAP EVERTYHGIN AROUND MY HEAD

Models: package that has classes that show the class version of json

Services: package that holds to functionality to grab data from api and return the appropiate class objects

ViewModels how you want your model class to be displayed 
 */

namespace Project3_FinalExam.Models
{
    public class About
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Quote { get; set; }
        public string QuoteAuthor { get; set; }

    }
}
