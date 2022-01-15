using System;

namespace MitchellsDeliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfGuests;
            int waters = 0;
            int saki = 0;

            while (true)
            {
                Console.WriteLine("Hi. Welcome to our Buffet. All you can eat for $9.99! We only charge extra for saki. How many people are in your group? Please, parties of 6 or lower.");
                numOfGuests = Double.Parse(Console.ReadLine());
                if (numOfGuests > 6)
                    Console.WriteLine("Too many people. Please leave.");
                else break;

            }
            
            Console.WriteLine($"A table for {numOfGuests}! Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or saki.");
            for (int i = 0; i < numOfGuests; i++)
            {
                Console.WriteLine($"Alright, person number {i+1}, water or saki?");
                string answer = Console.ReadLine();

                if (answer == "saki")
                {
                    Console.WriteLine("Saki, great choice");
                    saki++;
                }
                else
                {
                    Console.WriteLine("Water, great choice");
                    waters++;
                }
            }
            double total = (numOfGuests * 9.99) + (saki * 5.00);
            Console.WriteLine($"I have {waters} waters and {saki} sakis. Your total will be ${total}");


        }
    }
}
