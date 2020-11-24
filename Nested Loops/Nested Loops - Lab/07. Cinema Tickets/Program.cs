using System;
using System.Runtime.InteropServices.ComTypes;

namespace Билети_за_кино
{
    class Program
    {
        static void Main(string[] args)
        {
            int standartTicket = 0;
            int studentTicket = 0;
            int kidTicket = 0;
            while (true)
            {
                string movieName = Console.ReadLine();
                if (movieName == "Finish")
                {
                    break;
                }
                int capacity = int.Parse(Console.ReadLine());
                int movieTicketsSold = 0;
                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }

                    if (ticketType == "standard")
                    {
                        standartTicket++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTicket++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTicket++;
                    }
                    movieTicketsSold++;

                    if (movieTicketsSold == capacity)
                    {
                        break;
                    }


                }
                double hallPrecent = movieTicketsSold * 1.0 / capacity * 100;
                Console.WriteLine($"{movieName} - {hallPrecent:f2}% full.");
            }
            int totalTickets = kidTicket + studentTicket + standartTicket;
            double studentTicketsPErcentage = studentTicket * 1.0 / totalTickets * 100;
            double standartTicketsPErcentage = standartTicket * 1.0 / totalTickets * 100;
            double kidTicketsPErcentage = kidTicket * 1.0 / totalTickets * 100;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentTicketsPErcentage:f2}% student tickets.");
            Console.WriteLine($"{standartTicketsPErcentage:F2}% standard tickets.");
            Console.WriteLine($"{kidTicketsPErcentage:f2}% kids tickets.");
        }
    }
}
