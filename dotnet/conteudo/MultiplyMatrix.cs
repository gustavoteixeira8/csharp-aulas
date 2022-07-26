namespace MultiplyMatrix;

public class Program {
    public static void Main1() 
    {

        while (true) {
            string userValue = Console.ReadLine();

            Test: 
            {
                Console.Write("The program finish");
            }


            if (userValue == "Goto") {
                goto Test;
            } else {
                break;
            }
        }
    }
}