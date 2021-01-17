using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleProject.ViewModels
{
    public class HomeDetailsViewModel
    {
        public Employee employee { get; set; }
        public string PageTitle { get; set; }
    }
}
