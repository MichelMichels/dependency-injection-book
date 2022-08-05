using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled.Domain;

public class ProductService : IProductService
{
    private readonly IProductRepository productRepository;
    private readonly IUserContext userContext;

    public ProductService(IProductRepository productRepository, IUserContext userContext)
    {
        this.productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        this.userContext = userContext ?? throw new ArgumentNullException(nameof(userContext));
    }   

    public IEnumerable<DiscountedProduct> GetFeaturedProducts()
    {
        return productRepository.GetFeaturedProducts().Select(x => x.ApplyDiscountFor(this.userContext));
    }
}
