namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictonaryDemo();
        }
        private static void doDictonaryDemo()
        {
            Console.WriteLine("\n do DictonaryDemo");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Rahul");
            dictionary.Add(102, "Vijay");

            Console.WriteLine("Access value using key(key=100): " + dictionary[100]);

            Console.WriteLine("\n Interating Dictonary :");
            foreach(var element in dictionary)
            {
                Console.WriteLine("key =" + element.Key + "& Value = " + element.Value);
            }
        }
        private static void doSetDemo()
        {
            Console.WriteLine("\nIn doSetDemo");

            var set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doQueueDemo()
        {
            Console.WriteLine("\n doQueueDemo");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Raj");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");
            Console.WriteLine("Head:" +queue.Peek());
            Console.WriteLine("\nInterating the Queue Element");

            foreach(var element in queue)
            {
                Console.WriteLine(element);
            }
            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue Element:"+dequeue);
            Console.WriteLine("\n Interating the Queue Element after Dequeue One Element");

            Queue<string>.Enumerator enumerator = queue.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        private static void doStackDemo()
        {
            Console.WriteLine("\nIn doStackDemo");

            Stack<string> stack = new Stack<string>();

            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            stack.Push("Garima");
            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped Element: " + pop);
        }
        private static void doListDemo()
        {
            Console.WriteLine("\nIn doListDemo");

            List<string> list = new List<string>();

            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach(var element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}