using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TightlyCoupled.Domain;
using TightlyCoupled.Data;

namespace TightlyCoupled.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            bool isPreferredCustomer = this.User.IsInRole("PreferredCustomer");

            var service = new ProductService();

            var products = service.GetFeaturedProducts(isPreferredCustomer);

            this.ViewData["Products"] = products;
        }
    }
}
