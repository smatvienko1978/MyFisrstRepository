using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_JesseCookies
{
    class Program
    {
        public class MyQueue
        {
            private static Queue<int> start;
            private static Queue<int> work;

            public MyQueue(List<int> startItems)
            {
                start = new Queue<int>();
                work = new Queue<int>();

                startItems.Sort();
                for (int i = 0; i < startItems.Count; i++)
                    start.Enqueue(startItems[i]);
            }

            public void Enqueue(int value)
            {
                work.Enqueue(value);
            }
            public int Dequeue()
            {
                if (start.Count == 0 && work.Count == 0)
                    return -1;
                int startValue = int.MaxValue;
                if (start.Count > 0)
                    startValue = start.Peek();

                int workValue = int.MaxValue;
                if (work.Count > 0)
                    workValue = work.Peek();

                if (startValue < workValue)
                    return start.Dequeue(); // start.Count > 0?start.Dequeue():-1;
                return work.Dequeue();// work.Count > 0?work.Dequeue():-1;
            }
        }
        public static int cookies(int k, List<int> A)
        {
            var result = 0;
            var cookie1 = 0;
            var cookie2 = 0;
            var mixCookie = 0;
            var myCookies = new MyQueue(A);
            
            while (true)
            {
                cookie1 = myCookies.Dequeue();
                cookie2 = myCookies.Dequeue();
                mixCookie = cookie1 + 2 * cookie2;
                if (cookie1 >= k && cookie2 >= k)     break;
                if ( cookie2 == -1) //(cookie1 == -1 ||
                {
                    if (cookie1 >= k)
                        return result;
                    else
                    return -1;
                }

                myCookies.Enqueue(mixCookie);
                result++;
            }
            return result;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(cookies(7, new List<int>() { 1, 2, 3, 9, 10, 12 })); //2
            //Console.WriteLine(cookies(10, new List<int>() { 1, 1, 1 })); //-1
            //Console.WriteLine(cookies(90, new List<int>() { 13, 47, 74, 12, 89, 74, 18, 38 })); //5

            var arr = new int[100000];
            for (int i = 0; i < 100000; i++)
                arr[i] = 1;
            Console.WriteLine(cookies(105823341, arr.ToList<int>())); //99999


            Console.ReadKey();
        }
    }
}
