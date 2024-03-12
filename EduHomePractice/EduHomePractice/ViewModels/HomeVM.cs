using EduHomePractice.Models;
using System.Collections.Generic;

namespace EduHomePractice.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<Service> Services { get; set; }
        public About About { get; set; }
    }
}
