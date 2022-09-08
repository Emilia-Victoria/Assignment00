// See https://aka.ms/new-console-template for more information
namespace MyApp {

public class Program {
    public static bool IsLeapYear(int year){return year % 4 == 0;}
    public static void Main(){
        Console.WriteLine("Enter year: ");
        int input = Convert.ToInt32(Console.ReadLine());
        if (IsLeapYear(input)){
            Console.WriteLine("yay");
        } else {
            Console.WriteLine("nay");
        }
    }
}
}
