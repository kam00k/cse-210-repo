using System;

class Program
{
    static void Main(string[] args)
    {

        //load a raw scripture. In this case we're just using a single string. 
        string scripture = ("John 3:16\nFor God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        //this version will be used to test using separate strings
        //string scripture = ("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        //string reference = ("John 3:16");

        //instantiate a new Scripture object with the scripture string.
        Scripture gameScripture = new Scripture(scripture);

        
    }
}