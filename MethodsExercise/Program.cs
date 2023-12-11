using System;

namespace MethodsExercise

{
    class Program
    {

        public static int Sum(int num1, int num2)
        {

            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;

        }
        static void Main(string[] args)
        {
            var amountOfGifts = Sum(2, 6);
            var amountOfMoney = Multiply(5, 10, 100);

            Console.WriteLine($" {amountOfGifts} ");
            Console.WriteLine($" {amountOfMoney} ");

            // Excercise 1
            //Name: Adrienne
            //From: California
            //Singer: Khelani
            //Song: Good Thing 

            Console.WriteLine("Greetings! What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Welcome {userName} Where are you from?"!);
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
        }
    }

}
    
        //Exercise#2 Methods Exercise!!!
        
           
        
   
    
