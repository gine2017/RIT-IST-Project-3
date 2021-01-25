      using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3_FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetFaculty _facultyRepository;
        private readonly IGetStaff _staffRepository;
        private readonly IGetMinor _minorRepository;
        private readonly IGetGraduate _gradRepo;
        private readonly IGetUnderGrad _undergradRepo;

        public HomeController(IGetFaculty facultyRepository, IGetStaff staffRepository,
            IGetMinor minorRepository, IGetGraduate gradRepo, IGetUnderGrad underGradRepo)
        {
            _facultyRepository = facultyRepository;
            _staffRepository = staffRepository;
            _minorRepository = minorRepository;
            _gradRepo = gradRepo;
            _undergradRepo = underGradRepo;
        }

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public async Task<IActionResult> IndexAsync()
        {
            /*var getAbout = new GetAbout();
            var abt = await getAbout.GetAboutData();
            var abtViewModel = new AboutViewModel()
            {
                About = abt,
                Title = "All About Us"
            }
            return View(abtViewModel);*/
            var modelAbtDegree = new EmployandAboutViewModel();
            var getAbout = new GetAbout();
            var degreeStat = new GetDegreeStats();
            var employIntro = new GetEmployIntro();
            var employersData = new GetEmployersData();
            var careerData = new GetCareerData();
            var employTableData = new GetEmployerTableData();
            var coopTableData = new GetCoopTableData();
            modelAbtDegree.About = await getAbout.GetAboutData();
            modelAbtDegree.DegreeStats = await degreeStat.GetStatData();
            modelAbtDegree.EmployIntro = await employIntro.GetEmployStatData();
            modelAbtDegree.Employers = await employersData.GetEmployersInfo();
            modelAbtDegree.Careers = await careerData.GetCareerInfoData();
            modelAbtDegree.EmploymentTable = await employTableData.GetEmployerTable();
            modelAbtDegree.CoopTable = await coopTableData.GetCoopTable();

            return View(modelAbtDegree);
        }

        public async Task<IActionResult> GetFaculty()
        {
            var allFaculty = await _facultyRepository.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var allStaff = await _staffRepository.GetAllStaff();
            var sortedStaff = allStaff.OrderBy(f => f.username);
            var homeViewModel = new HomeViewModel();
            homeViewModel.Faculty = allFaculty.ToList();
            homeViewModel.Staff = allStaff.ToList();
            /*{
                Faculty = allFaculty.ToList(),
                Staff = allStaff.ToList(),
                Title = "This is your Faculty"
            };*/
            return View(homeViewModel);
        }

        public async Task<IActionResult> Under()
        {
            var getUnder = await _undergradRepo.GetAllUnderGrad();
            var getGrad = await _gradRepo.GetAllGrad();
            var getMinor = await _minorRepository.GetAllMinor();
        
            var underViewModel = new UndergradViewModel();
            /*{
                UnderGrads = under,
                Title = "Undergraduate Programs"
            };*/
            underViewModel.UnderGrads = getUnder.ToList();
            underViewModel.Graduate = getGrad.ToList();
            underViewModel.UgMinor = getMinor.ToList();
            return View(underViewModel);
        }

        public IActionResult AboutInfo()
        {
            AboutViewModel abt = new AboutViewModel();
            return View(abt);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
