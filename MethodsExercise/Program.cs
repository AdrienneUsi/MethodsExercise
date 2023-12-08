using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Excercise 1
            //Name: Adrienne
            //From: California
            //Singer: Khelani
            //Song: Good Thing 

            Console.WriteLine("Greetings! What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName} Where are you from?");
            var from = Console.ReadLine();

            Console.WriteLine($"Wow! {from} is a great place! Who is your favorite singer?");
            var singer = Console.ReadLine();

            Console.WriteLine($"{singer} is a extrodinary artist. What is your favorite song?");
            var song = Console.ReadLine();

            Console.WriteLine($"Thanks {userName} for answering these questions.These are some fun facts about you!");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"From: {from}");
            Console.WriteLine($"Favorite Singer:{singer}");
            Console.WriteLine($"Favirite Song:{song}");

        } }

        }

        
   
    
