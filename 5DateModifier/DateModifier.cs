class DateModifier
{
    int difference;
    public int Difference
    {  get; set; }

    public void CalculateDifference(string date1, string date2)
    {

        TimeSpan dateDifference = DateTime.Parse(date1) - DateTime.Parse(date2);
        Difference = dateDifference.Days;
    }
}
