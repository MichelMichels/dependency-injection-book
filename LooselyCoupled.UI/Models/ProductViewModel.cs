using System.Globalization;
using LooselyCoupled.Domain;

namespace LooselyCoupled.UI.Models;

public class ProductViewModel
{
    private static CultureInfo PriceCulture = new CultureInfo("en-US");

    public ProductViewModel(DiscountedProduct discountedProduct) : this(discountedProduct.Name, discountedProduct.UnitPrice)
    {
    }

    public ProductViewModel(string name, decimal unitPrice)
    {
        this.SummaryText = string.Format(PriceCulture, "{0} ({1:C})", name, unitPrice);
    }

    public string SummaryText { get; }
}
