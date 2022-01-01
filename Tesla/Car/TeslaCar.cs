using System.Text;

namespace CompositePattern.Tesla.Car;

public abstract class TeslaCar : ICarCatalogComponent
{
    public string Brand { get; set; } = "Tesla";

    public string PaperType { get; set; } = string.Empty;
    public bool IsColorPrint { get; set; } = false;
    
    public abstract string Model { get; set; }
    public abstract double Price { get; set; }

    public bool Add(ICarCatalogComponent component) => false;
    public bool Remove(ICarCatalogComponent component) => false;
    public IEnumerable<ICarCatalogComponent>? GetChildren() => null;
    
    public override string ToString()
    {
        return $"Brand: {Brand}, Model: {Model}, Price: {Price}";
    }
}