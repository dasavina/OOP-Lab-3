class Engine
{
    public string model
    { get; set; }
    int power
    { get; set; }
    int displacement
    { get; set; }
    string efficiency
    { get; set; }

    public Engine(string model, int power, string displacement, string efficiency)
    {
        this.model = model;
        this.power = power;
        this.displacement = (displacement is null)? -1:Convert.ToInt16(displacement);
        this.efficiency = (efficiency is null)? "n/a":efficiency;
    }

    public override string ToString()
    {
        return "{model} \n\tPower: {power} \n\tDisplasement: {displasement} \n\tEfficiency: {efficiency}";
    }
}