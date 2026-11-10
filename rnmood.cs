using System;

class Program
{
    static void Main()
    {
        string[] moods =
        {
            "happy",
            "sad",
            "excited",
            "sleepy",
            "angry",
            "confused",
            "motivated"
        };

        Random rnd = new Random();

        Console.WriteLine("mood" + moods[rnd.Next(moods.Length)]);
    }
}
