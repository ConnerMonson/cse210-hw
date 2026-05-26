class Program
{
    static void Main(string[] args)
    {
        // create videos
        Video video1 = new Video("The World is Flat", "Barnaby", 484);
        Video video2 = new Video("How to make bread", "The BreadMan", 1245);
        Video video3 = new Video("Explaining Physics", "Physics 101", 323);

        // add comments
        video1.AddComment("Michelle", "This video is a bunch of lies.");
        video1.AddComment("BV1290", "I think this dude is totally really. He knows");
        video1.AddComment("Francisco Demoyez", "This was weird");

        video2.AddComment("Jake Wilson", "This bread tasted so good, thanks for the vid");
        video2.AddComment("SarahMills", "My bread did not turn out like his, what happened?");
        video2.AddComment("Ehtan Mikvad", "Wow, just wow");

        video3.AddComment("MyFriend", "My brain blew up at minute 1.");
        video3.AddComment("Miko Sneako", "I don't understand and ive watched this video 20 times now.");
        video3.AddComment("DinoSarah", "This was for babies, it was so dumbed down");

        // create list of videos
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        // clear console
        Console.Clear();
        // loop through videos and display info
        foreach (Video video in videos)
        {
            Console.WriteLine($"\n{video.GetDisplayText()}");
            Console.WriteLine("\nComments:");
            
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine(comment.DisplayComment());
            }
        }
    }
}