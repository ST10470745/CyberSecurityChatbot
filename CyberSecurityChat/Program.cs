using System;

namespace CyberSecurityChat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            AsciiArt.DisplayLogo();

            VoiceGreeting.PlayGreeting();

            Console.Write("\nPlease enter your name: ");
            string userName = Console.ReadLine();

            Chatbot bot = new Chatbot(userName);
            bot.StartChat();
        }
    }
}
