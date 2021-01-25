 using System.Collections.Generic;

public class Statistic
{
    public string value { get; set; }
    public string description { get; set; }
}


public class DegreeStats
{
    public string title { get; set; }
    public List<Statistic> statistics { get; set; }
}

