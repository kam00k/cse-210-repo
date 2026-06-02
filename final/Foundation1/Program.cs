using System;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videoList = new List<Video>();

        videoList.Add(new Video("99 ways to peel a blackcurrant", "Fruitland Slasher", 3096));
        videoList.Add(new Video("How I sawed this boat in half using the all new Flex Saw", "Billy Mays", 600));
        videoList.Add(new Video("It's over...", "Asmongold", 234));

        videoList[0]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[0]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[0]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[0]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));

        videoList[1]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[1]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[1]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[1]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));

        videoList[2]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[2]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[2]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));
        videoList[2]._commentList.Add(new Comment("xXxTankSlayerxXx", "This is crazy, I wish I had learned this when I was an epic cod player"));

        foreach (var video in videoList)
        {
            Console.WriteLine($"Video Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Video Length (Seconds): {video._length}");
            Console.WriteLine($"Number of Comments: {video.GetCommentNumber()}");
            
            video.ListComments();
        }
    }
}