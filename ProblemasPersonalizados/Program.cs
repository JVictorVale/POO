using ProblemasPersonalizados.Entities.Exceptions;

namespace ProblemasPersonalizados;
using ProblemasPersonalizados.Entities;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Clear();
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation reservation = new Reservation(number, checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

            Console.WriteLine();
            Console.WriteLine("Enter date to update the reservation");
            Console.Write("Check-in date (dd/MM/yyyy): ");
            checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            checkOut = DateTime.Parse(Console.ReadLine());
            
            Console.WriteLine();
            reservation.UpdateDates(checkIn, checkOut);
            Console.WriteLine("Reservation: " + reservation);

        }
        catch (DomainException e)
        {
            Console.WriteLine("Error in reservation: " + e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Format error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected error: " + e.Message);
        }

    }
}