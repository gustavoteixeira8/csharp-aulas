namespace dotnet_aulas;

public class MyMath
{
    public int sum(int n1, int n2)
    {
        return n1 + n2;
    }

    public int subtract(int n1, int n2)
    {
        return n1 - n2;
    }

    public int divide(int n1, int n2)
    {
        return n1 / n2;
    }

    public int multiply(int n1, int n2)
    {
        return n1 * n2;
    }

}

public class MyDelegate {
    delegate int Op(int n1, int n2);

    public static void Exec()
    {
        MyMath math = new MyMath();

        Op op = null;

        op = math.sum;

        int result = op(10, 50);

        Console.WriteLine(result);
    }
}