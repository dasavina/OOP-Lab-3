class Car
{
    string Model
    { get; set; }
    Engine engine { get; set; }
    int weight
    { get; set; }
    string color
    { get; set; }

    public Car(string model, Engine engine, string weight, string color)
    {
        Model = model;
        this.engine = engine;
        this.weight = (weight is null) ? -1 : Convert.ToInt16(weight);
        this.color = (color is null) ? "n/a" : color;
    }

    public override string ToString()
    {
        return "{model} \n\t{engine.ToString()} \n\tWeight: {weight} \n\tColor: {color}";
    }
}