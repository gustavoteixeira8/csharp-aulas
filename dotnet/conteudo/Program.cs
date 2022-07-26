namespace ConvertTemperature;

public class Program {
    public static void Main1(string[] args) {
        double celcius, fahrenheit, kelvin;

        Console.WriteLine("### CONVERSOR DE TEMPERATURAS ###");
        Console.WriteLine("### USE . AO INVÉS DE , ###");
        Console.WriteLine("Digite uma temperatura em graus celcius: ");

        string userValue = Console.ReadLine();

        if (string.IsNullOrEmpty(userValue) || string.IsNullOrWhiteSpace(userValue)) {
            Console.WriteLine("Digite um valor válido");
            return;
        }

        bool isOk = double.TryParse(userValue, out celcius);

        if (!isOk) {
            Console.WriteLine("Algum erro ocorreu. Tente novamente!");
            return;
        }

        fahrenheit = celcius  * 9 / 5 + 32;
        kelvin = celcius + 273.15d;

        Console.WriteLine($"Em celcius: {userValue}");
        Console.WriteLine($"Em fahrenheit: {fahrenheit}");
        Console.WriteLine($"Em kelvin: {kelvin}");
    }
}