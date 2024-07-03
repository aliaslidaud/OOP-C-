namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings myStack = new StackOfStrings();

            Console.WriteLine(myStack.IsEmpty());
            Console.WriteLine();

            myStack.Push("Asli");
            myStack.Push("Ali");
            myStack.Push("Meliha");
            myStack.Push("Gyulnur");
            myStack.Push("Gyunay");

            while (!myStack.IsEmpty())
            {
                Console.WriteLine(myStack.Pop());
            }

        }
    }
}
