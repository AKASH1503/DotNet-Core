using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SampleProject.Models;

namespace SampleProject.Controller
{
    public class HomeController : ControllerBase
    {
        private IEmployeeRepository _employeeRepository;

        /// <summary>
        /// Its is Controctur Injection
        /// </summary>
        /// <param name="employeeRepository"></param>
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }  
        public string Index()
        {
            return _employeeRepository.GetEmployee(2).Name;
        }
    }
}
