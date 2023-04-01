class Program
{
    static void Main(string[] args)
    {

        string input = "abccbdeeda";
        Stack<char> stack = new Stack<char>();
        foreach (char c in input)
        {
            if (stack.Count > 0 && c == stack.Peek())
            {
                stack.Pop();
                Console.Write("-");
            }
            else
            {
                Console.Write(c);
                stack.Push(c);
            }
            Console.WriteLine();
            for (int i = 0; i < stack.Count; i++)
            {
                Console.Write("-");
            }
        }
    }
}






