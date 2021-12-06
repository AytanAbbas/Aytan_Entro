
using Entro.Data;
using Entro.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Entro.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context) 
        {
           _context = context;
        }

        
        public IActionResult Index()
        {
            //    List<Gallery> gallery = _context.Galleries.Include("GalleryImage").ToList(); 


            return View();
        }


    }
}
