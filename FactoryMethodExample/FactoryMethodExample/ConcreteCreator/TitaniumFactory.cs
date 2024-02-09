using FactoryMethodExample.ConcreteProduct;
using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;

namespace FactoryMethodExample.ConcreteCreator;

public class TitaniumFactory : CardFactory
{
    private decimal _limit;
    private int _annualBilling;

    public TitaniumFactory(decimal limit, int annualBilling)
    {
        _limit = limit;
        _annualBilling = annualBilling;
    }

    public override CreditCard SearchCreditCard()
    {
        return new TitaniumCard(_limit, _annualBilling);
    }
}
