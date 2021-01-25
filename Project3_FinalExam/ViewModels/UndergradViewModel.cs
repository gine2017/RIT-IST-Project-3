using System.Collections.Generic;
using Project3_FinalExam.Models;

namespace Project3_FinalExam.ViewModels
{
    public class UndergradViewModel
    {
        public List<UnderGradMajors> UnderGrads { get; set; }
        public List<Graduate> Graduate { get; set; }
        public List<UgMinor> UgMinor { get; set; }
        public string Title { get; set; }
    }
}
