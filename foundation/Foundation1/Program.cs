using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> youtube = new List<Video>();

        CreateVideo(youtube);
        foreach(Video video in youtube)
        {
            video.GetDetails();
            video.ListComments();
        }

    }


    private static void CreateVideo(List<Video> youtube)
    {
        Video video1 = new Video("The NBA App | All Season. All Free.","NBA",30);
        Comment comment1 = new Comment("Roberto Luna","Give us local and national games league pass");
        Comment comment2 = new Comment("Maria Flores","free nba league pass?");
        Comment comment3 = new Comment("Amelia Philler","I’m just glad it didn’t show Luka or LeBron in this video");
        Comment comment4 = new Comment("Charlotte Mai","cool!");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);
        video1.AddComment(comment4);
        youtube.Add(video1);
        
        Video video2 = new Video("NFL MVP RACE HEATING UP Josh Allen or Lamar Jackson? 'I'M SHOCKED' - Dan Orlovsky | Get Up","ESPN",814);
        comment1 = new Comment("Marvin clark","Bruh this is all a week to week thing, it’s always so flip floppy.");
        comment2 = new Comment("Superman","Not a ravens fan. But remember they was saying Lamar should play WR. Lmaoooo.");
        comment3 = new Comment("Tiger hoods","lol I bet they won’t criticize mahomes turning the ball over so much this year");
        comment4 = new Comment("Josh Heart","They been talking about it all year");
        video2.AddComment(comment1);
        video2.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);
        youtube.Add(video2);

        Video video3 = new Video("South Bay Lakers vs Stockton Kings | Lakers Highlights","LakeShow Highlights",452);
        comment1 = new Comment("Andrea Pirlo","This what I been waiting for.");
        comment2 = new Comment("Kayle Cusma","Nice Game");
        comment3 = new Comment("Mr NBA","Let's go LAKERS");
        comment4 = new Comment("Elfy Smith","His got that Iverson vibe");
        video3.AddComment(comment1);
        video3.AddComment(comment2);
        video3.AddComment(comment3);
        video3.AddComment(comment4);        
        youtube.Add(video3);

        Video video4 = new Video("Have I Got News For You' comedians react to little-known fact about Jeff Bezos' background","CNN",605);
        comment1 = new Comment("Pizza Speed","So happy to see Roy Woods on a news channel comedy show!");
        comment2 = new Comment("Raven Claw","The pairing of Amber and Scaramucci is so awkward.");
        comment3 = new Comment("Marcelo Taz","I liked it");
        comment4 = new Comment("Big Zac","Auto captions are a real problem.");
        video4.AddComment(comment1);
        video4.AddComment(comment2);
        video4.AddComment(comment3);
        video4.AddComment(comment4);        
        youtube.Add(video4);
    }
}