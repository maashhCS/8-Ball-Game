using System;

namespace _8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int mydelay = 1000;
            string[] eightBool = { "It is certain.", "It is decidedly so.", "Without a doubt.", "Yes definitely.",
                "You may rely on it.", "As I see it, yes.", "Most likely.", "Outlook good.", "Yes.", "Signs point to yes.", "Reply hazy, try again.", "Ask again later.",
                "Better not tell you now.", "Cannot predict now.", "Concentrate and ask again.", "Don't count on it.", "My reply is no.", "My sources say no.", "Outlook not so good.", "Very doubtful.", };

            bool stillPlaying = true;
            while (stillPlaying)
            {
                int index = rand.Next(eightBool.Length);
                Console.Write("Type ur question: ");
                Console.ReadLine();
                Console.WriteLine("thinking.");
                Thread.Sleep(mydelay);
                Console.WriteLine("thinking..");
                Thread.Sleep(mydelay);
                Console.WriteLine("thinking...");
                Thread.Sleep(mydelay);
                Console.WriteLine($"{eightBool[index]}");
                Console.Write("Do you still want to play?: ");
                string answer = Console.ReadLine();
                if (answer == "Yes")
                {
                    continue;
                }
                else stillPlaying = false;
            }
        }
    }
}
