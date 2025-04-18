namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new CalculatorMethod();
            int result = calculator.Add(3, 5);
            Console.WriteLine($"Результат: {result}");
        }
    }
    public class CalculatorMethod
    {
        // Метод для сложения двух чисел
        public int Add(int a, int b)
        {
            return a + b;
        }

    
}
}
