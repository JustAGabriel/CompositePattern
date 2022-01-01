using System.Collections.Immutable;
using System.Security.AccessControl;

namespace CompositePattern;

public class CarSalesExpert
{
    private readonly IEnumerable<ICarCatalogComponent> _carCatalogs;

    public CarSalesExpert(IEnumerable<ICarCatalogComponent> carCatalogs)
    {
        _carCatalogs = carCatalogs;
    }

    public void PrintAllCatalogs()
    {
        foreach (var catalog in _carCatalogs)
        {
            Console.WriteLine(catalog.ToString());
        }
    }

    public void PrintCarsInPriceRange(double maxPrice, double minPrice = 0.0)
    {
        Console.WriteLine($"Cars in the price range from '{ minPrice }' up to '{ maxPrice }':");
        foreach (var catalog in _carCatalogs)
        {
            foreach (var car in catalog.GetChildren()?.ToList())
            {
                if (car.Price >= minPrice && car.Price <= maxPrice)
                    Console.WriteLine(" -" + car.ToString());
            }
        }
    }
}