using Microsoft.AspNetCore.Mvc;
using RootView.Models;

namespace RootView.Controllers
{
    public class ProductController:Controller
    {
        public ContentResult Info(int id)
        {
            return Content(id.ToString());
        }
        public ViewResult Detail(int id) 
        {
            ProductModel model = new ProductModel();

            model.Id = id;

            return View(model);
        
        
        }
    }
}
