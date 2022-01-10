namespace Application;

public interface ICalculator
{
    int Add(int a, int b);
    int Divide(int a, int b);
}

public class Calculator : ICalculator
{
    public int Add(int a, int b) => a + b;

    public int Divide(int a, int b) => a / b;
}