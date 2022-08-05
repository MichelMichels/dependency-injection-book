using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooselyCoupled.Domain;

public class DiscountedProduct
{
    public DiscountedProduct(string name, decimal unitPrice)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        UnitPrice = unitPrice;
    }

    public string Name { get; }
    public decimal UnitPrice { get; }
}
