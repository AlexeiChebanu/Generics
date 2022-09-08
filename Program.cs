namespace GenericsType
{
    class Stack<T>
    {
        private List<T> stack = new List<T>();
        public int Count { get { return stack.Count; } }
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

        public T Peek()
        {
            return stack.Last();
        }
        public T[] CopyTo(T[] array)
        {
            T[] tmpStack = stack.ToArray();
            Array.Reverse(tmpStack);

            for (int i = tmpStack.Length - 1; i > 0; i--)
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
            stack.Push(123);
            stack.Push(456);
            stack.Push(13453);
            stack.Push(0);

            int[] MyStackData = new int[stack.Count];
            stack.CopyTo(MyStackData);

            foreach (int i in MyStackData)
            {
                Console.WriteLine(i);
            }
        }
    }
}