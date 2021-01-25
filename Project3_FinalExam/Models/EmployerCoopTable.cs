using System.Collections.Generic;
public class CoopInformation
{
    public string employer { get; set; }
    public string degree { get; set; }
    public string city { get; set; }
    public string term { get; set; }
}

public class CoopTable
{
    public string title { get; set; }
    public List<CoopInformation> coopInformation { get; set; }
}
