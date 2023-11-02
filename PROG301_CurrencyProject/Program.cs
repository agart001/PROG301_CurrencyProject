using static PROG301_CurrencyProject.Utility.Method_Utils;

namespace PROG301_CurrencyProject
{
    public class ExampleClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Type targetType = typeof(ExampleClass);
            string methodName = "Add";
            object[] methodParameters = new object[] { 3, 4 };

            int result = InvokeMethod<int>(targetType, methodName, methodParameters);
            Console.WriteLine("Result: " + result);
        }
    }
}