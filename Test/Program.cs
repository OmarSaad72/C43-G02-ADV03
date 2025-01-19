namespace Test
{
    internal class Program
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp = x; x = y; y = temp;
        }
        static void Main()
        {
            #region LinkedList
            //LinkedList<int> linkedlist = new LinkedList<int>();
            //linkedlist.AddFirst(1);
            //linkedlist.AddLast(2);
            //linkedlist.AddFirst(3);
            ////linkedlist.AddBefore(linkedlist.First, 4);
            ////linkedlist.AddAfter(linkedlist.Last, 5);
            //LinkedListNode<int>? node = linkedlist.Find(1);
            //linkedlist.AddBefore(node, 5);
            //foreach (int i in linkedlist)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1); // add elements in stack
            //stack.Push(2); // add elements in stack
            //stack.Push(3); // add elements in stack
            //stack.Push(4); // add elements in stack  , TOP
            ////Console.WriteLine(stack.Peek()); //return top elemnt
            //stack.Pop(); // remove elements in stack {start from top}
            //stack.Pop(); // remove elements in stack {start from top}
            //stack.Pop(); // remove elements in stack {start from top}
            //stack.Pop(); // remove elements in stack {start from top}
            //stack.TryPop(out int value); // remove elements in stack {start from top}, but handled the exceptions if stack was empty
            //stack.TryPeek(out int value2); // handled the exceptions if stack was empty and set default value
            //foreach (int i in stack)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Queue
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1); // add elements
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue(); // remove first element
            queue.Dequeue(); // remove first element
            queue.Dequeue(); // remove first element
            queue.TryPeek(out int value);
            //queue.TryDequeue(out int value2);
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
