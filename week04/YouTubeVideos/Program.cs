using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        Console.Clear();
Video firstVideo = new Video(name: "First Poster", title: "First Video", length: 45);
firstVideo.AddComment("Great video!", name: "Matthew");
firstVideo.AddComment("Loved it!", name: "Mark");
firstVideo.AddComment("Very informative!", name: "Luke");
firstVideo.DisplayVideoInformation();

// Video 2
Video secondVideo = new Video(name: "Second Poster", title: "Second Video", length: 120);
secondVideo.AddComment("Awesome!", name: "John");
secondVideo.AddComment("Can't wait for part 2!", name: "Peter");
secondVideo.AddComment("Nice editing!", name: "Bartholomew");
secondVideo.DisplayVideoInformation();

// Video 3
Video thirdVideo = new Video(name: "Third Poster", title: "Third Video", length: 90);
thirdVideo.AddComment("This is hilariou`s!", name: "James");
thirdVideo.AddComment("Best video I've seen today!", name: "James");
thirdVideo.AddComment("Subscribed!", name: "Doug");
thirdVideo.DisplayVideoInformation();

// Video 4
Video fourthVideo = new Video(name: "Fourth Poster", title: "Fourth Video", length: 200);
fourthVideo.AddComment("So helpful, thanks!", name: "Stephen");
fourthVideo.AddComment("I learned a lot!", name: "Paul");
fourthVideo.AddComment("Can you make more like this?", name: "Burt");
fourthVideo.DisplayVideoInformation();

    }
}