class Tire
{
    public double tirePressure
    { get; set; }
    public int tireAge
    { get; set; }

    public double[] getEngine()
    {
        double[] data = { tirePressure, tireAge };
        return data;
    }
}