using System.Text;
using System.Text.Json;

namespace CompositePattern.Tesla;

public class TeslaCatalog : ICarCatalogComponent
{
    public TeslaCatalog()
    {
        _cars = new();
    }
    
    private List<ICarCatalogComponent> _cars;

    public string Brand { get; set; } = "Tesla";
    public string PaperType { get; set; } = "Digital only";
    public bool IsColorPrint { get; set; } = true;
    public string Model { get; set; } = string.Empty;
    public double Price { get; set; } = default;
    
    public bool Add(ICarCatalogComponent component)
    {
        int originalCount = _cars.Count;
        _cars.Add(component);
        int updatedCount = _cars.Count;
        
        return updatedCount > originalCount;
    }

    public bool Remove(ICarCatalogComponent component)
    {
        return _cars.Remove(component);
    }

    public IEnumerable<ICarCatalogComponent>? GetChildren()
    {
        return _cars;
    }

    public override string ToString()
    {
        StringBuilder builder = new();
        builder.AppendLine("Brand: " + Brand);
        builder.AppendLine("Paper type: " + PaperType);
        builder.AppendLine("Is color print: " + IsColorPrint);
        builder.AppendLine("Cars:");
        foreach (var car in _cars)
        {
            builder.AppendLine(" -" + car.ToString());
        }

        return builder.ToString();
    }
}