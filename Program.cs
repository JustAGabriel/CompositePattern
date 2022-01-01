using CompositePattern;
using CompositePattern.Mercedes;
using CompositePattern.Mercedes.Car;
using CompositePattern.Tesla;
using CompositePattern.Tesla.Car;

TeslaCatalog teslaCatalog= new();
teslaCatalog.Add(new ModelS());
teslaCatalog.Add(new ModelY());

MercedesCatalog mercedesCatalog = new();
mercedesCatalog.Add(new AmgGle());
mercedesCatalog.Add(new E350());

IEnumerable<ICarCatalogComponent> catalogs = new List<ICarCatalogComponent> { teslaCatalog, mercedesCatalog };
CarSalesExpert salesExpert = new(catalogs);
salesExpert.PrintAllCatalogs();
salesExpert.PrintCarsInPriceRange(150_000, 90_000);

