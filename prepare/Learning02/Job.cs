using System.ComponentModel.DataAnnotations;

public class Job {
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job() 
    {
    }

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
