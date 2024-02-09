using FactoryMethodExample.ConcreteCreator;
using FactoryMethodExample.Creator;
using FactoryMethodExample.Product;

CardFactory? cardFactory = null;
Console.Write("Digite o tipo de cartão que deseja obter: ");
string? console = Console.ReadLine();

switch (console?.ToLower())
{
	case "black":
		cardFactory = new BlackFactory(5000, 0);
		break;
	case "titanium":
		cardFactory = new TitaniumFactory(10000, 100);
		break;
	case "platinum":
		cardFactory = new PlatinumFactory(50000, 500);
		break;
	default:
		break;
}

CreditCard? creditCard = cardFactory?.SearchCreditCard();
Console.WriteLine("\nOs detalhes do seu cartão estão abaixo: ");
Console.WriteLine("Tipo do cartão: {0}\nLimite: {1}\nCobrança anual: {2}", creditCard?.Type, creditCard?.Limit, creditCard?.AnnualBilling);
Console.ReadKey();
