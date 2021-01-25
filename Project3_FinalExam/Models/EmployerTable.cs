using System;
using System.Collections.Generic;

public class ProfessionalEmploymentInformation
{
    public string employer { get; set; }
    public string degree { get; set; }
    public string city { get; set; }
    public string title { get; set; }
    public string startDate { get; set; }
}

public class EmploymentTable
{
    public string title { get; set; }
    public List<ProfessionalEmploymentInformation> professionalEmploymentInformation { get; set; }
}
