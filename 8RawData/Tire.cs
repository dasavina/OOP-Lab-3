class Tire
{
    public double tirePressure
    { get; set; }
    public int tireAge
    { get; set; }

    public Tire(double tirePressure, int tireAge)
    {
        this.tirePressure = tirePressure;
        this.tireAge = tireAge;
    }
}