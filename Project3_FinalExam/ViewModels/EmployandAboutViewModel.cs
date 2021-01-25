/*
 custom model to show both employ data and about data
 */

using System;
using Project3_FinalExam.Models;
namespace Project3_FinalExam.ViewModels
{
    public class EmployandAboutViewModel
    {
        public About About { get; set; }
        public DegreeStats DegreeStats { get; set; }
        public EmployIntro EmployIntro { get; set; }
        public Employers Employers { get; set; }
        public Careers Careers  { get; set; }
        public EmploymentTable EmploymentTable { get; set; }
        public CoopTable CoopTable { get; set; }
    }
}
