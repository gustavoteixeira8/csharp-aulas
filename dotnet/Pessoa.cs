namespace dotnet_aulas;

public class Person 
{
    public string name;
    public string lastName;
    public int birthdate;

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
    }
}
