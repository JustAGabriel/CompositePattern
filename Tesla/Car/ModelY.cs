namespace CompositePattern.Tesla.Car;

public class ModelY : TeslaCar
{
    public override string Model { get; set; } = "Model Y";
    public override double Price { get; set; } = 120_000;
}