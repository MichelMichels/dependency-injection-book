using System.Text.Json;
using LooselyCoupled.Domain;

namespace LooselyCoupled.DataAccess;

public class JsonProductRepository : IProductRepository
{
    private readonly string directoryPath;

    public JsonProductRepository(string directoryPath)
    {
        this.directoryPath = directoryPath ?? throw new ArgumentNullException(nameof(directoryPath));
    }

    public IEnumerable<Product> GetFeaturedProducts()
    {
        var products = new List<Product>();
        
        if(Directory.Exists(directoryPath))
        {
            var files = Directory.GetFiles(directoryPath, "*.json");
            foreach(var file in files)
            {
                var json = File.ReadAllText(file);
                var product = JsonSerializer.Deserialize<Product>(json);
                if(product != null)
                {
                    products.Add(product);
                }
            }
        }         
        
        return products;        
    }
}
