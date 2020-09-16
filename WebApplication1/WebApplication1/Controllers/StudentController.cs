using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Courses_Lab5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        IStudent _std;
        IDepartment _dept;

        public StudentController(IStudent std, IDepartment dept)
        {
            _std = std;
            _dept = dept;


        }
        public IActionResult Index()
        {

            return View(_std.GetStudents());
        }
        //Mock Repository
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {

            if (ModelState.IsValid)
            {
                _std.AddStudent(std);

                return RedirectToAction("Index");
            }
            return View(std);

        }
        public IActionResult Delete(int Id)
        {

            _std.DeleteStudent(Id);




            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {

            return View(_std.FindStudent(Id));
        }
        [HttpPost]
        public IActionResult Edit(Student std)
        {

            if (ModelState.IsValid)
            {
                _std.UpdateStudent(std);

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }
        // the db repository
        public IActionResult Details(int id)
        {
            return View(_std.FindStudent(id));
        }
        [HttpGet]
        public IActionResult Create2()
        {
            ViewBag.DeptId = new SelectList(_dept.GetDepartments(), "DeptId", "DeptName");
            return View();
        }
        [HttpPost]
        public IActionResult Create2(Student std)
        {

            if (ModelState.IsValid)
            {
                _std.AddStudent(std);

                return RedirectToAction("Index");
            }
            return View(std);

        }

        [HttpGet]
        public IActionResult Edit2(int Id)
        {
            ViewBag.DeptId = new SelectList(_dept.GetDepartments(), "DeptId", "DeptName");
            return View(_std.FindStudent(Id));
        }
        [HttpPost]
        public IActionResult Edit2(Student std)
        {

            if (ModelState.IsValid)
            {
                _std.UpdateStudent(std);

                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");

        }
        // the db repository

    }
}