public class VideoList
{

    private List<Video> _videoList;
    public VideoList()
    {
        //create a list of video objects
        _videoList = new List<Video>();

        //populate the list with Video objects, passing in their information as parameters
        _videoList.Add(new Video("99 ways to peel a blackcurrant", "Fruitland Slasher", 3096));
        _videoList.Add(new Video("How I sawed this boat in half using the all new Flex Saw", "Billy Mays", 600));
        _videoList.Add(new Video("It's over...", "Asmongold", 234));

        //Add comments to each video's comment list, passing in the author name and text body as parameters
        _videoList[0]._commentList.Add(new Comment("Peter Suund", "Very relaxing. I have this on in the background whenever I need to relax"));
        _videoList[0]._commentList.Add(new Comment("Henry Hilfinger", "The fruitland slasher is at it again! 10/10 would watch again"));
        _videoList[0]._commentList.Add(new Comment("surgeon324", "Unironically helped me pass my last med school class."));

        _videoList[1]._commentList.Add(new Comment("epiclulz420", "this isnt even billy mays, i want a refund"));
        _videoList[1]._commentList.Add(new Comment("Preston Johnston", "I liked the part where he sawed the boat in half."));
        _videoList[1]._commentList.Add(new Comment("LydiaWulf1992", "Where can I order one of these? He forgot to mention."));
        _videoList[1]._commentList.Add(new Comment("123tapeman", "now put the boat back together again."));

        _videoList[2]._commentList.Add(new Comment("averageAsmonEnjoyer", "1:24 TRUEEEEEEE"));
        _videoList[2]._commentList.Add(new Comment("hankHill", "I never want to move to Beirut..."));
        _videoList[2]._commentList.Add(new Comment("hulk_hogan_rip", "I saw a cockroach crawl out of his cup. never change."));
        _videoList[2]._commentList.Add(new Comment("kailentit", "ok but how is this going to help me ship a button in 2026?"));
    }

    public void DisplayAllVideos()
    {
        //iterate through each video
        foreach (var video in _videoList)
        {
            video.ShowVideo();
        }
        
        //final formatting line to keep it neat
        Console.WriteLine("\n-------------------------------------");
    }
}