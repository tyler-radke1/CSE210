using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)

    //Creativity: To boost this project, I made a ScripturePicker class where the user can input a chosen book of scripture, and it will use some JSON files to randomly 
    //pick a verse from that book
    {
        var reference = new Reference(book: "1 Nephi", chapter: "2", "15");
        var scripture = new Scripture(reference: reference, text: "And my father dwelt in a tent");

        var randomScripture = ScripturePicker.GetRandomScripture(selectedBook: ScriptureBook.BookOfMormon);
        string hiddenText = randomScripture.GetFullText();

        while (true)
        {
            Console.WriteLine("Press any key to continue, or type 'quit' to quit.");

            var entry = Console.ReadLine();

            if (entry == "quit")
            {
                return;
            }

            Console.Clear();

            hiddenText = randomScripture.Hide(hiddenText);

            Console.WriteLine($"{randomScripture.GetFullReference()} - {hiddenText}");
        }
        

    }
}