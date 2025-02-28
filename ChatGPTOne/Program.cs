using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                case "How old are you?":
                    response = "I'm 1 day old!";
                    break;
                case "What do you do?":
                    response = "Talk to you.";
                    break;
                case "Where are you?":
                    response = "Inside your computer.";
                    break;
                case "Are you more intelligent than me?":
                    response = "Obviously!";
                    break;
                default:
                    response = "I don't think I can answer that";
                    break;
            }

            // Responder adequadamente
            Console.WriteLine(response);
        }
    }
}
