class Program
{
    static void Main(string[] args)
    {
        Assignment baseAssignment = new Assignment("Tyler", "General Studies");
        Console.WriteLine(baseAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new MathAssignment("Tyler", "Fractions", "Section 7.3", "Problems 10–20");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.HomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Tyler", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
