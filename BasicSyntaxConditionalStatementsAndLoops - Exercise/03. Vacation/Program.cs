using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;
            switch (type)
            {
                case "Students":
                    if(day == "Friday")
                    {
                        totalPrice = countOfPeople * 8.45;
                                               
                    }
                    else if(day == "Saturday")
                    {
                        totalPrice = countOfPeople * 9.80;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = countOfPeople * 10.46;
                    }
                    if(countOfPeople >= 30)
                    {
                        totalPrice = totalPrice * 0.85;
                    }
                    break;
                case "Business":
                    if (countOfPeople >= 100)
                    {
                        countOfPeople = countOfPeople - 10;
                    }
                    if (day == "Friday")
                    {
                        totalPrice = countOfPeople * 10.9;

                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = countOfPeople * 15.6;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = countOfPeople * 16;
                    }
                    
                    break;
                case "Regular":
                    if (day == "Friday")
                    {
                        totalPrice = countOfPeople * 15;

                    }
                    else if (day == "Saturday")
                    {
                        totalPrice = countOfPeople * 20;
                    }
                    else if (day == "Sunday")
                    {
                        totalPrice = countOfPeople * 22.5;
                    }
                    if (countOfPeople >= 10 && countOfPeople <= 20)
                    {
                        totalPrice = totalPrice * 0.95;
                    }
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
