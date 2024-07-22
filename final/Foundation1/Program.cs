using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Adopting kitties", "Marcos Valencia", 620);
        video1.createComment("Juansito1", "Nice job!");
        video1.createComment("Annie39", "I like that orange cat");
        video1.createComment("Pencil3849", "I want to donate food to you");
        video1.createComment("Jhonsari2", "Try dogs next time");
        Video video2 = new Video("Random song", "Random singer", 242);
        video2.createComment("Randomguy382", "I hate this songgg");
        video2.createComment("Newuser02", "Nice song my guy");
        video2.createComment("Nick392", "I like the last part");
        Video video3 = new Video("Playing a new game with you!", "Youtuber9383", 743);
        video3.createComment("Hater93939", "Why are you so bad at this game?");
        video3.createComment("Specting39", "Try a new strategy the next time...");
        video3.createComment("Achulli839832", "Get off your cloud, you are not that good");
        video3.createComment("Pamela9309", "Nice job bro!");
        Video video4 = new Video("Investigation on new virus", "Lab Mas", 928);
        video4.createComment("JuanferQuinteroooo", "Why is this video so addictive to see?");
        video4.createComment("JohnKeyes", "I wanna work with you, please contact me");
        video4.createComment("MatthieuK", "Nice investigation, I really like the method you use");
        Console.WriteLine(video1.getInfo());
        Console.WriteLine(video2.getInfo());
        Console.WriteLine(video3.getInfo());
        Console.WriteLine(video4.getInfo());
    }
}