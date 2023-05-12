using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication4.DAL;
using WebApplication4.Models;
using WebApplication4.ViewModels;

namespace WebApplication4.Controllers
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
            List<Slide> slides = new List<Slide>();
            slides.Add(new Slide { Image = "1-1-524x617.png", Title = "Salam Dunya", Description = "Akulalar salam" ,Order = 2});
            slides.Add(new Slide { Image = "1-2-270x300.jpg", Title = " Real Madrid", Description = "Barcelona" ,Order=1});

            List<Product> products = new List<Product>();
            products.Add(new Product {Id=1,Name="Roza",Price=4m,Image="has.jpg" });

            List<Client> clients = new List<Client>();
            clients.Add(new Client {Id=1,FullName="Ulvi Asadzade " , Duty="Teacher" ,Description="Mukemmel melimdir",Image="qabil.jpg"});
            clients.Add(new Client { Id = 1, FullName = "Sabir Guliyev ", Duty = "Teacher", Description = "Mukemmel melimdir", Image = "download.jpg" });
            clients.Add(new Client { Id = 1, FullName = "Yasin Hesenli ", Duty = "Student", Description = "Mukemmel Telebedir", Image = "marnueli.jpg" });

            HomeVM homeVM = new HomeVM
            {
                slides = slides.OrderBy(s => s.Order).Take(2).ToList(),
                products=products,
                clients=clients
                
            };
            return View(homeVM);
        }
        public IActionResult Details(int? id)
        {
            if (id == null || id < 1) return BadRequest();

            Product product = _context.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);

            if (product == null) return NotFound();

            return View(product);
        }
        public IActionResult About()
        {
            return View();
        }

    }
}
