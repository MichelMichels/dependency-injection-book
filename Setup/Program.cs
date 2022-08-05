using TightlyCoupled.Data;

using var context = new CommerceContext();

var products = new List<Product>()
{
    new Product() {
        Id = Guid.NewGuid(),
        Name = "Gruyère",
        Description = "",
        IsFeatured = true,
        UnitPrice = 48.50m,
    },
    new Product() {
        Id = Guid.NewGuid(),
        Name = "White Aspargus",
        Description = "",
        IsFeatured = true,
        UnitPrice = 39.80m,
    },
    new Product() {
        Id = Guid.NewGuid(),
        Name = "Anchovies",
        Description = "",
        IsFeatured = true,
        UnitPrice = 18.75m,
    },
    new Product() {
        Id = Guid.NewGuid(),
        Name = "Arborio Rice",
        Description = "",
        IsFeatured = true,
        UnitPrice = 22.75m,
    },
};

context.Products.AddRange(products);
//context.SaveChanges();

Console.WriteLine("Done.");
