using FrontToBack_Karma.Models;
using FrontToBack_Karma.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FrontToBack_Karma.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>()
            {
                new Slider
                {
                    Id= 1,
                    MainTitle = "Əsl orginal vasmoy Nike-leri",
                    SubTitle = "Bizden alin razi qalin",
                    ImageUrl ="s-1.jpg",
                },
                 new Slider
                {
                    Id= 2,
                    MainTitle = "Kitayski Abibas mallari",
                    SubTitle = "Serfeli qiymetlere",
                    ImageUrl ="s-2.jpg",
                },
                  new Slider
                {
                    Id= 1,
                    MainTitle = "Serfeli mallar",
                    SubTitle = "Almasanizda olar",
                    ImageUrl ="s-3.jpg",
                }
            };
            List<Football> footballs = new List<Football>()
            {
                new Football
                {
                    Id = 1,
                    ImageUrl="Sir.png",
                },
                new Football
                {
                    Id = 2,
                    ImageUrl="Benzema.jpg",
                },
                new Football
                {
                    Id = 3,
                    ImageUrl="Hakan.jpg",
                },
                new Football
                {
                    Id = 4,
                    ImageUrl="Ronaldo.jpg",
                },
                new Football
                {
                    Id = 5,
                    ImageUrl="Merih.jpg",
                },

            };

            HomeVM model = new HomeVM
            {
               Sliders = sliders,
               Footballs = footballs,
                
            };
            return View(model);
        }
       
    }
}
