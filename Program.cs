namespace GenericsType
{
    class Stack<T>
    {
        private List<T> stack = new List<T>();

        public void Push(T value)
        {
            stack.Add(value);
        }

        public T Pop()
        {
            T value = stack.Last();
            stack.Remove(stack.Last());
            return value;
        }

        public void Clear()
        {
            stack.Clear();
        }

        public int Count() 
        { 
            return stack.Count;
        }

        public T Peek()
        {
            return stack.Last();
        }
        public T[] CopyTo(T[] array)
        {
            T[] tmpStack = stack.ToArray();
            Array.Reverse(tmpStack);

            for (int i = tmpStack.Length - 1; i >= 0; i--)
            {
                array[i] = tmpStack[i];
            }

            return array;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            int[] copyStack = new int[stack.Count()];
            stack.CopyTo(copyStack);

            foreach (int i in copyStack)
                Console.WriteLine(i);
        }
    }
}
//checked
