using Microsoft.AspNetCore.Mvc;
using RootView.Models;

namespace RootView.Controllers
{
    public class HomeController : Controller
    {
     public ViewResult Index()
        {
            return View();

        }
        public ViewResult About() {
            return View();
        }
        public ViewResult Contact()
        {
            return View();
        }
      
    }
}
