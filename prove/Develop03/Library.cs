//Jack Wilson
//CSE210
//Week 3 Develop Project - Encapsulation

//I figured I'd make this library its own class just to make the main program file a bit tidier.
class Library
{
    //An array of scripture strings. Note that they all have a newline between the reference and the text.
    private string[] _scriptureList =
    {
      "John 3:16\nFor God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",

      "Words of Mormon 1:9-11\nAnd now I, Mormon, proceed to finish out my record, which I take from the plates of Nephi; and I make it according to the knowledge and the understanding which God has given me. Wherefore, it came to pass that after Amaleki had delivered up these plates into the hands of king Benjamin, he took them and put them with the other plates, which contained records which had been handed down by the kings, from generation to generation until the days of king Benjamin.",

      "1 Samuel 3:10\nAnd the Lord came, and stood, and called as at other times, Samuel, Samuel. Then Samuel answered, Speak; for thy servant heareth."
    };

    //returns a random scripture string from the library.
    public string GetRandomScripture()
    {
        Random rand = new Random();
        int randInt = rand.Next(0, _scriptureList.GetLength(0));
        return _scriptureList[randInt];
    }
}