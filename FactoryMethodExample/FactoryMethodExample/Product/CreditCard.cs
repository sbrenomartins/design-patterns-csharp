namespace FactoryMethodExample.Product;

public abstract class CreditCard
{
    public abstract string Type { get; }
    public abstract decimal Limit { get; set; }
    public abstract int AnnualBilling { get; set; }
}
