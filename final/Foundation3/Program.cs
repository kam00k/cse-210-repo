//Jack Wilson
//CSE 210
//Final Project, Program 3

class Program
{
    static void Main(string[] args)
    {
        //Create one Event object of each type and pass in all the information they need to their constructors.
        Lecture lecture = new Lecture("Lagrangian Points: Mysterious Gravity Bowls", "Come hear a fascinating speech on the secret regions of space where gravity itself cancels out.", "September 15th, 2008", "7:00PM", "Dr. Andrew Lariviere", 125);
        Reception reception = new Reception("Billy Kid and Nicole's Wedding", "We never thought we'd see the day but our Billy's all grown up and found himself a sweetheart! Come celebrate with everyone, the more the merrier!", "02/23/2024", "4:30PM", "bobbykidd1962@hotmail.com");
        Outdoor outdoor = new Outdoor("Guy Fawkes' Night", "Ever wanted to burn an effigy of the OG political terrorist? Well, come on down and have some outside fun. There'll be a massive bonfire too!", "November 5th, 2018", "16:30", "It's expected to be a clear night, but will be chilly if you're not near the fire. Dress however you like, but be prepared for the cold!");

        //set the addresses for each Event object.
        lecture.SetAddress("35 Eversleigh Rd", "Hornchurch", "PA", "09382");
        reception.SetAddress("87000 Gentile Street", "Layton", "UT", "84041");
        outdoor.SetAddress("65 Paul Hill Road", "Madison", "NH", "03832");

        //Have each Event object output its three descriptions. 
        lecture.StandardDescription();
        lecture.FullDescription();
        lecture.ShortDescription();

        reception.StandardDescription();
        reception.FullDescription();
        reception.ShortDescription();
    
        outdoor.StandardDescription();
        outdoor.FullDescription();
        outdoor.ShortDescription();
    }
}