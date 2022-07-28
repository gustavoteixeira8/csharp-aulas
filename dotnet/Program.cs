namespace dotnet_aulas;

public class Program
{
    public static void Main() 
    {
        /*
        Person p1 = new Person()
        {
            name = "Gustavo",
            lastName = "Teixeira",
            birthdate = 2003
        };

        Person p2 = new Person("Ana", "C", 2003);

        // p2.name = "Ana";
        // p2.lastName = "C";
        // p2.birthdate = 2003;

        Console.WriteLine($"Pessoa 1: {p1.name} {p1.lastName} / {p1.birthdate}");
        p1.Cumprimentar();
        Console.WriteLine("-------------");
        Console.WriteLine($"Pessoa 2: {p2.name} {p2.lastName} / {p2.birthdate}");
        p2.Cumprimentar();

        var value = 50;

        Console.WriteLine($"Antes do método: {value}");

        p2.AumentarValoPorRef(ref value);

        Console.WriteLine($"Depois do método: {value}");

        p2.Cumprimentar("Nai");

        Console.WriteLine(OtherMath.Sum(50, 20));
        Console.WriteLine(OtherMath.Subtract(50, 20));

        // MyDelegate.Exec();
        */

        TestWithGettersAndSetters t = new("Gustavo", "Teixeira");

        Console.WriteLine(t.Name);
        Console.WriteLine(t.Lastname);

        t.Name = "Ana";
        // t.Lastname = "C"; // Error

        Console.WriteLine(t.Name);
        Console.WriteLine(t.Lastname);
    }        
}

