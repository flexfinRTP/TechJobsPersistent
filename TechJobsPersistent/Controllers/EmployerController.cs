﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;
using TechJobsPersistent.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext context;

        public EmployerController(JobDbContext jobContext)
        {
            context = jobContext;
        }

        // GET: /<controller>/

        public IActionResult Index()
        {
            List<Employer> employers = context.Employers.ToList();

            return View(employers);
        }

        [HttpGet]
        public IActionResult AddEmployer()
        {
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();

            return View("Add", addEmployerViewModel);
        }

        [HttpPost]
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location
                };

                context.Employers.Add(newEmployer);
                context.SaveChanges();

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        public IActionResult About(int id)
        {
            Employer newEmployer = context.Employers.Find(id);


            return View(newEmployer);
        }
    }
}