using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace Demo
{
    internal class Program
    {
        public static void swap<T>(ref T x, ref T y)
        {
            T temp = x; x = y; y = temp;
        }

        class StringComparer : IEqualityComparer
        {
            public new bool Equals(object? x, object? y)
            {
                string? a = x as string;
                string? b = y as string;
                return a?.ToLower().Equals(b?.ToLower()) ?? (b is null ? true : false);
            }

            public int GetHashCode(object obj)
            {
                string? a = obj as string;
                return a?.ToLower().GetHashCode() ?? 0;
            }
        }

        class ComparerGenerics : IEqualityComparer<string>
        {
            public bool Equals(string? a, string? b)
            {
                return a?.ToLower().Equals(b?.ToLower()) ?? (b is null ? true : false);
            }

            public int GetHashCode([DisallowNull] string a)
            {
                return a?.ToLower().GetHashCode() ?? 0;
            }
        }

        class SortedDictionary : IComparer<string>
        {
            public int Compare(string? x, string? y)
            {
                return y?.CompareTo(x) ?? 0;
            }
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
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1); // add elements
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Dequeue(); // remove first element
            //queue.Dequeue(); // remove first element
            //queue.Dequeue(); // remove first element
            //queue.TryPeek(out int value);
            ////queue.TryDequeue(out int value2);
            //foreach (var i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region HashTable{Non-Generic}
            //Hashtable note = new Hashtable(/*new StringComparer()*/);
            //note.Add("Omar", 7132);
            //note.Add("Mai", 2445);
            //note.Add("mai", 445);  // Invalid
            //note.Add("Mohammed", 4332);
            //Console.WriteLine(note["Omar"]);
            //note["Mai"] = 123;
            //Console.WriteLine(note["Mai"]);
            //foreach (DictionaryEntry i in note)
            //{
            //    //Console.WriteLine(i);
            //    Console.WriteLine($"{i.Key}: {i.Value}");
            //}
            //Console.WriteLine(note.ContainsKey("Omar"));
            //Console.WriteLine(note.Contains("Sara"));
            //Console.WriteLine(note.ContainsValue(7132));
            //Console.WriteLine(note.ContainsValue(71));
            #endregion
            #region Dictionary
            //KeyValuePair<string, int>[] keys = new KeyValuePair<string, int>[]
            //{
            //    new KeyValuePair<string, int>("Yara" ,424),
            //    new KeyValuePair<string, int>("Ali" ,234),
            //    new KeyValuePair<string, int>("Hala" ,256)
            //};
            //Dictionary<string, int> Note = new Dictionary<string, int>(keys)
            //Dictionary<string, int> Note = new Dictionary<string, int>(new ComparerGenerics())
            //{
            //    {"Omar", 123},
            //    {"Mai" ,321 },
            //    {"Saad" ,456 },
            //};
            //Note.Add("Sara", 766); //  InValid
            //Note.Add("mai", 324);
            //Note.Remove("Mai");
            //Note.TryAdd("Sara", 766);
            //if (!Note.ContainsKey("Omar"))
            //    Note.Add("Omar", 222);
            //else
            //    Note["Omar"] = 222;
            //foreach (KeyValuePair<string, int> i in Note)
            //{
            //    Console.WriteLine($"{i.Key}: {i.Value}");
            //}

            //foreach (string key in Note.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            #endregion
            #region Sorted Dictionary
            SortedDictionary<string, int> SortedNote = new SortedDictionary<string, int>(new SortedDictionary());
            SortedNote.Add("Omar", 7132);
            SortedNote.Add("Mazen", 132);
            SortedNote.Add("Zain", 342);
            foreach (KeyValuePair<string, int> i in SortedNote)
            {
                Console.WriteLine($"{i.Key} & {i.Value}");
            }
            #endregion
        }
    }
}
