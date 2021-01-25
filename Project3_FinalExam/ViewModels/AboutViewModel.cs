using System.Collections.Generic;
using Project3_FinalExam.Models;

/*
 View models differ from domain models in that view models only
contain the data (represented by properties) that you want to use on your view.

TO HELP ME WRAP EVERTYHGIN AROUND MY HEAD

Models: package that has classes that show the class version of json

Services: package that holds to functionality to grab data from api and return the appropiate class objects

ViewModels how you want your model class to be displayed 
 */
namespace Project3_FinalExam.ViewModels
{
    public class AboutViewModel
    {
        public About About { get; set; }
        public string Title { get; set; }
    }
}
