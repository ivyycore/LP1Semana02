using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {

            string question = "";
            string response;
            while (question != "EXIT")
            {

                Console.Write("What's your question? ");
                question = Console.ReadLine();


                    switch (question)
                    {
                        case "How old are you?":
                            Console.WriteLine("I'm 1 day old!");
                            break;
                        case "What do you do?":
                            Console.WriteLine("Talk to you.");
                            break;
                        case "Where are you?":
                            Console.WriteLine("Inside your computer.");
                            break;
                        case "Can you install a virus in my computer?":
                            Console.WriteLine("I'm doing it right now!");
                            break;
                        case "EXIT":
                            break;
                        default:
                            Console.WriteLine("I don't think I can answer that");
                            break;
                        
                    
                    }
            }
        }
    }
}
