namespace SoftwareDesignPrinciples.Yagni;

public class SimpleCalculatorYagniViolation
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    // Unnecessary method added (YAGNI violation)
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}