using System;
using System.Threading;

namespace CyberSecurityChat
{
    class Chatbot
    {
        public string UserName { get; set; }

        public Chatbot(string name)
        {
            UserName = name;
        }

        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHello {UserName}! How can I help you today?");
            Console.ResetColor();

            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter a valid question.");
                    continue;
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            Thread.Sleep(600);

            if (input.Contains("how are you"))
            {
                Console.WriteLine("Bot: I'm just code, but I'm here to help you stay safe online!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("Bot: My purpose is to educate users about cybersecurity risks and how to stay safe online.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use strong passwords with letters, numbers, and symbols. Never reuse passwords.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing emails try to trick you into giving personal information. Always check the sender carefully.");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("Bot: Only visit trusted websites and avoid clicking suspicious links.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("Bot: You can ask about password safety, phishing attacks, or safe browsing.");
            }
            else
            {
                Console.WriteLine("Bot: I didn’t quite understand that. Could you rephrase?");
            }
        }
    }
}
