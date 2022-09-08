namespace MyApp {

public class Program {
    public static bool IsLeapYear(int year){return year % 4 == 0;}
    public static void Main(){
        Console.WriteLine("Enter year: ");
        bool legalInput = false;
        int input = 0;
        while (legalInput == false) {
            try {
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 1582) {
                    throw new Exception();
                }
                legalInput = true;
            } catch (Exception e) {
                Console.WriteLine("Input needs to be a number and above 1582.");
                Console.WriteLine("Enter year: ");
            }
        }

        if (IsLeapYear(input)){
            Console.WriteLine("yay");
        } else {
            Console.WriteLine("nay");
        }
    }
}
}
