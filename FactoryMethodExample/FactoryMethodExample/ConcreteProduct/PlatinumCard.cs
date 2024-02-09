using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteProduct;

public class PlatinumCard : CreditCard
{
    private readonly string _type;
    private decimal _limit;
    private int _annualBilling;

    public PlatinumCard(decimal limit, int annualBilling)
    {
        _type = "Platinum";
        _limit = limit;
        _annualBilling = annualBilling;
    }

    public override string Type
    {
        get { return _type; }
    }

    public override decimal Limit
    {
        get { return _limit; }
        set { _limit = value; }
    }

    public override int AnnualBilling
    {
        get { return _annualBilling; }
        set { _annualBilling = value; }
    }
}
