public class Resume
{
    string name;

    public List<Job> _jobs = [];

    public void displayJobs()
    {
        foreach (var job in _jobs)
        {
            Console.WriteLine(job);
        }
    }
}