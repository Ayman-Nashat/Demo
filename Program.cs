using System.Collections;
namespace Demo
{
    internal class Program
    {
        public static int sum(List<int> arr)
        {
            if (arr == null) return 0;
            int res = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                res += arr[i];
            }
            return res;
        }
        static void Main(string[] args)
        {
            #region ArrayList
            //ArrayList arr = new ArrayList();
            //for (int i = 0; i < 10; i++)
            //{
            //    arr.Add(i);
            //    //Console.WriteLine($"count = {arr.Count} : Capacity = {arr.Capacity}");
            //}
            //for (int i = 0;i < 5; i++)
            //{
            //    arr.Remove(i);
            //    Console.WriteLine($"count = {arr.Count} : Capacity = {arr.Capacity}");
            //}
            //arr.TrimToSize();
            //Console.WriteLine($"count = {arr.Count} : Capacity = {arr.Capacity}");

            #endregion

            #region List
            //List<int> arr = new List<int>();
            //Console.WriteLine($"count = {arr.Count} : Capacity = {arr.Capacity}");
            //arr.AddRange(new int[]{ 1,2,3,4,5,8,8,4,5,8,8});
            //for (int i = 0; i < 5; i++)
            //{
            //    arr.Remove(i);
            //    Console.WriteLine($"count = {arr.Count} : Capacity = {arr.Capacity}");
            //}
            //Console.WriteLine($"count = {arr.Count} : Capacity = {arr.Capacity}");
            //Console.WriteLine(sum(arr));
            #endregion

            #region List Methods
            //List<int> arr = new List<int>();
            //arr.Add(1);
            //arr.AddRange(new int[] { 2, 3, 4 });
            //arr.Insert(4, 5);
            //arr.InsertRange(5, new int[] { 6, 7, 8, 9 });
            //Console.WriteLine($"Result of binary Search of 5 :{arr.BinarySearch(5)}");
            //arr.Clear();
            //Console.WriteLine(arr.Contains(6));
            //int[] array = new int[] { 0,0,0,0,0,0,0,0,0,0,0,0};
            //arr.CopyTo(array,1);
            //foreach (int i in array)
            //{
            //    Console.Write(i + " ");
            //}
            //arr.TrimExcess();
            //Console.WriteLine(arr.Capacity);
            //arr.EnsureCapacity(20);
            //Console.WriteLine(arr.Capacity);
            //Console.WriteLine(arr.IndexOf(0));
            //Console.WriteLine(arr.IndexOf(5));
            //Console.WriteLine(arr.LastIndexOf(5));
            #endregion

            #region LinkedList
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddFirst(1);
            //list.AddFirst(2);
            //list.AddLast(3);
            //list.AddAfter(list.First,6);
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i+" ");
            //}
            #endregion

            #region Stack
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //while (stack.Count > 0)
            //{
            //    Console.WriteLine(stack.Pop());
            //}
            #endregion

            #region Queue
            //Queue<int> q = new Queue<int>();
            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //while(q.Count > 0)
            //{
            //    Console.WriteLine(q.Dequeue());
            //}
            #endregion
        }
    }
} 
