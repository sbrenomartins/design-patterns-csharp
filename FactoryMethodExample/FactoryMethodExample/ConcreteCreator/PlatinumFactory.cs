using FactoryMethodExample.ConcreteProduct;
using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteCreator;

public class PlatinumFactory : CardFactory
{
    private decimal _limit;
    private int _annualBilling;

    public PlatinumFactory(decimal limit, int annualBilling)
    {
        _limit = limit;
        _annualBilling = annualBilling;
    }

    public override CreditCard SearchCreditCard()
    {
        return new PlatinumCard(_limit, _annualBilling);
    }
}
