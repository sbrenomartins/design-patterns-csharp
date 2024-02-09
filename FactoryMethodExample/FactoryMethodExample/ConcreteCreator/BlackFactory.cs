using FactoryMethodExample.ConcreteProduct;
using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteCreator;

public class BlackFactory : CardFactory
{
    private decimal _limit;
    private int _annualBilling;

    public BlackFactory(decimal limit, int annualBilling)
    {
        _limit = limit;
        _annualBilling = annualBilling;
    }

    public override CreditCard SearchCreditCard()
    {
        return new BlackCard(_limit, _annualBilling);
    }
}
