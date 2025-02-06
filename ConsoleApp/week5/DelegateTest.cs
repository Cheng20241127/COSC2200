namespace ConsoleApp.week5
{
    public class MathOperations
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    public class Calculator
    {
        Func<int, int, int> doer;
        public Calculator(Func<int, int, int> helper)
        {
            doer = helper;
        }
        public int Do( int x, int y)
        {
            return doer(x, y);
        }
    }
    internal class DelegateTest
    {
        delegate int Operation(int x, int y); //A delegate is a type
        public static void Test()
        {
        //public             
            MathOperations mathOps = new MathOperations();

            // Create delegate instances
            Calculator cal1 = new (mathOps.Add);
            Operation subtractOperation = mathOps.Subtract; //Operation is the same as Func<int, int, int>

            // Use the delegates
            int result1 = cal1.Do(5, 3); // Calls Add method
            int result2 = subtractOperation(5, 3); // Calls Subtract method

            Console.WriteLine("Addition Result: " + result1); // Output: 8
            Console.WriteLine("Subtraction Result: " + result2); // Output: 2
        }
    }
}
