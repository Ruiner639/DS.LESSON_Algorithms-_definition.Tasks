using System;
using System.Collections.Generic;

namespace DS.LESSON_Algorithms__definition.Tasks
{
    class Program
    {
        static void Main(string[] args)
          {
            int[] array = {4,3,2,5,6,7,8,1};
            int a = 0, b, min = array[0], max = 0;
            while(a < array.Length)
            {
                b = array[a];
                if(b < min)
                {
                    min = b;
                }
                a++;
            }
            a = 0;
            while (a < array.Length)
            {
                b = array[a];
                if (b > max)
                {
                    max = b;
                }
                a++;
            }
            int average = 0, sum = 0;
            a = 0;
            while (a < array.Length)
            {
                sum = sum + array[a];
                average = sum / array.Length;
                a++;
            }
            a = 0;
            int num = array[a];
            try
            {
                array[a] = array[a + 1];
                array[a + 1] = num;
            }
            catch
            {
                array[a] = array[a - 1];
                array[a - 1] = num;
            }
            Stack<int> MyStack = new Stack<int>();
            MyStack.Push(100);
            MyStack.Pop();
            int[] ar1 = {1,2,3,4,5};
            int[] ar2 = {6,7,8,9,0};
            a = 0;
            while (a < ar1.Length)
            {
                MyStack.Push(ar1[a]);
                a++;
            }
            a = 0;
            while (a < ar2.Length)
            {
                ar1[a] = ar2[a];
                a++;
            }
            a = 0;
            while (MyStack.Count != 0)
            {
                ar2[a] = MyStack.Pop();
                a++;
            }
            a = 0;
            int[] test = {3, 2, 5, 6, 7, 8, 1 };
            int id = 0;
            min = 10;
            while (a < test.Length)
            {
                b = test[a];
                if (b < min)
                {
                    min = b;
                    id = a;
                }
                a++;
            }
            Console.WriteLine(test[id]);
            num = test[0];
            test[0] = test[id];
            test[id] = num;
            Console.WriteLine(test[0]);

         }
    }
}
