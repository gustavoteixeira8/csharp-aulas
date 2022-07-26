namespace dotnet_aulas;

public class Person 
{
    public string name;
    public string lastName;
    public int birthdate;

    public Person(string name, string lastName, int birthdate)
    {
        this.name = name;
        this.lastName = lastName;
        this.birthdate = birthdate;
    }

    
    public Person()
    {
        this.name = "DEFAULT";
        this.lastName = "DEFAULT";
        this.birthdate = 1970;
    }

    public void Cumprimentar() 
    {
        Console.WriteLine($"Olá mundo!!! Eu sou {name} {lastName}");
    }

    public void AumentarValoPorRef(ref int valor) 
    {
        valor += 10;
        Console.WriteLine(valor);
    }

    public void Cumprimentar(string nome) 
    {
        Console.WriteLine($"Olá {nome}");
        Console.WriteLine($"Olá {nome} 2");
    }
}

public static partial class OtherMath
{
    public static int Sum(int n1, int n2)
    {
        return n1 + n2;
    }
}

public partial class OtherMath
{
    public static int Subtract(int n1, int n2)
    {
        return n1 - n2;
    }
}