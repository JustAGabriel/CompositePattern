namespace CompositePattern;

public interface ICarCatalogComponent
{
    public string Brand { get; set; }
    // catalog specific
    public string PaperType { get; set; }
    public bool IsColorPrint { get; set; }
    // car specific
    public string Model { get; set; }
    public double Price { get; set; }

    public bool Add(ICarCatalogComponent component);
    public bool Remove(ICarCatalogComponent component);
    public IEnumerable<ICarCatalogComponent>? GetChildren();
    string  ToString();
}