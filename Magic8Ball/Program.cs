using System;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {         
            string[] answers =
            {
                "Huh?",
                "What was that? Speak up.",
                "I didn't hear you.",
                "Oh, yeah. For sure.",
                "Without a doubt.",
                "Yes",
                "Most likely",
                "Spoiler warning...",
                "Uh...ask again later.",
                "It's a gray area.",
                "Really can't tell you now...",
                "VERY doubtful",
                "No",
                "Definitely not",
                "Do about twenty push-ups and try again for the answer."
            };                      

            while (true)
            {
                Random rnd = new Random();
                int result = rnd.Next(0, 15);

                Console.WriteLine("Welcome to Magic 8 Ball. Type in your question and hit enter for the answer.");

                string inp = Console.ReadLine();

                Console.Clear();

                Console.WriteLine(answers[result]);                               
            }
        }
    }
}
