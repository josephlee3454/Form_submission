
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using form_sub.Models;

namespace form_sub.Controllers
{
    public class FormController: Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("result")]
    
        public IActionResult result(Form list)
        {
            return View("Result", list);
        } 
        
        [HttpPost]
        [Route("process")]
        public IActionResult PostForm(Form Form)
        {
            Form YourForm = Form;

            return View("Result", Form);
        }
        [HttpGet("result")]
        public IActionResult Result(Form form)
        {
            return View(form);
        }
    }
    

}