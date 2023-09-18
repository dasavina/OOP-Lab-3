class Car
{
    public string Model
    { get; set; }
    public double FuelAmount
    { get; set; }
    public double FuelConsumption
    { get; set; }
    public double DistanceTravelled
    {
        get { return DistanceTravelled; }
        set { DistanceTravelled = (value != 0) ? DistanceTravelled + value : 0; }
    }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumption = fuelConsumption;
    }

    public string getCarInfo()
    {
        return (Model + " " + Math.Round(FuelAmount, 2) + " " + DistanceTravelled);
    }

    public bool CanDrive(double amountOfKm)
    {
        if (amountOfKm * FuelConsumption <= FuelAmount)
        {
            FuelAmount -= amountOfKm * FuelConsumption;
            DistanceTravelled = amountOfKm;
            return true;
        }
        else
        { return false; }
    }
}