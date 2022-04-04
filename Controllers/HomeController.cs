using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace EmployeeManagement.Controllers
{
    public class HomeController: Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public ViewResult Index()
        {
            //********return first employee name
            //return _employeeRepository.GetEmployee(1).Name;
            //********return all employee
            var model = _employeeRepository.GetAllEmployee();
                return View(model);

        }

        //public string Details()
        //{
        //    Employee model =_employeeRepository.GetEmployee(1);
        //    return _employeeRepository.GetEmployee(1).Name;
        //}

        public ViewResult Details()
        {

            /******Absolute view file path*******/

            //Employee model = _employeeRepository.GetEmployee(1);
            //return View("MyViews/Test.cshtml");


            /******Passing data to view using view data*******/

            //Employee model = _employeeRepository.GetEmployee(1);
            //ViewData["Employee"] = model;
            //ViewData["PageTitle"] = "Employee Details";
            //return View();

            /******Passing data to view using view bag*******/


            //Employee model = _employeeRepository.GetEmployee(1);
            //ViewBag.Employee= model;
            //ViewBag.PageTitle = "Employee Details";
            //return View();


            /******Passing data to view using Strongly Typed view *******/

            Employee model = _employeeRepository.GetEmployee(1);
            /********ViewBag.Employee = model;*******/
            ViewBag.PageTitle = "Employee Details";
            return View(model);







        }

    }
}
