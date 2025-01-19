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
            LinkedList<int> linkedlist = new LinkedList<int>();
            linkedlist.AddFirst(1);
            linkedlist.AddLast(2);
            linkedlist.AddFirst(3);
            //linkedlist.AddBefore(linkedlist.First, 4);
            //linkedlist.AddAfter(linkedlist.Last, 5);
            LinkedListNode<int>? node = linkedlist.Find(1);
            linkedlist.AddBefore(node, 5);
            foreach (int i in linkedlist)
            {
                Console.WriteLine(i);
            }
            #endregion
        }
    }
}
