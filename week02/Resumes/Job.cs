public class Job
{
    public string _company;
    public string _jobTitle;
    public int startYear;
    public int endYear;

    public void displayJob()
    {
        Console.WriteLine(_company);
        Console.WriteLine(_jobTitle);
        Console.WriteLine($"{startYear}");
        Console.WriteLine($"{endYear}");
    }


}