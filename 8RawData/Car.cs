class Car
{
    //model, engine, cargo and a collection of exactly 4 tires
    string Model
    { get; set; }

    Engine engine
    {  get; set; }
    Cargo cargo
    {  get; set; }

    List <Tire> tires = new List<Tire>(4);

    public string isFragile()
    {
        if (cargo.CargoType.Equals("fragile") && tires.Exists(x => x.tirePressure <1))
        {  return Model; }
        else
        {  return ""; }
    }

    public string isFlamable()
    {
        if (cargo.CargoType.Equals("flamable") && engine.EnginePower>250)
        { return Model; }
        else
        { return ""; }
    }

}
