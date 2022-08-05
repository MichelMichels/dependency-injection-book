using LooselyCoupled.Domain;
using LooselyCoupled.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LooselyCoupled.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;

        public HomeController(IProductService productService)
        {            
            this.productService = productService ?? throw new ArgumentNullException(nameof(productService));
        }

        public IActionResult Index()
        {
            IEnumerable<DiscountedProduct> products = productService.GetFeaturedProducts();

            var vm = new FeaturedProductsViewModel(products.Select(x => new ProductViewModel(x)));

            return View(vm);
        }      
    }
}
