namespace Aulas;

enum Notas 
{
    Min = 0,
    Med = 20,
    Max = 40,
}

public struct Pessoa 
{
    public string nome { get; set; }
    public int idade;
    public double altura;
    
    public Pessoa(string nome, int idade, double altura) {
        this.nome = nome;
        this.altura = altura;
        this.idade = idade;
    }
}

public class TiposDeDados 
{
    public static void Main1(string[] args) 
    {
        Pessoa p1 = new Pessoa("Gustavo", 19, 1.83D);

        // Console.WriteLine(p1);

        string n = "Olá mundo";

        for (int i = 0; i < n.Length; i++) {
            Console.WriteLine(n[i]);
        }
    }
}
