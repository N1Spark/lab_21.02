using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_21._02
{
    class Program
    {
        delegate bool Fun1(int x);
        delegate int Fun2(int x);
        delegate int Fun3(int x);
        delegate bool Fun4(int x);
        delegate int Fun5(int[] x);
        delegate int Fun6(int[] x);
        delegate void Fun7(int[] x);
        static void Main(string[] args)
        {
            #region 1
            Fun1 fun1 = delegate (int x)
            {
                return (x % 2 == 0 && x != 0);
            };
            Console.WriteLine(fun1(2));
            #endregion

            #region 2
            Fun2 fun2 = delegate (int x)
            {
                return x * x;
            };
            Console.WriteLine(fun2(2));
            #endregion

            #region 3
            Fun3 fun3 = x => x * x * x;
            Console.WriteLine(fun3(2));
            #endregion

            #region 4
            Fun4 fun4 = x => x == 256;
            Console.WriteLine(fun4(256));
            #endregion

            #region 5
            int[] arr = { 10, 2, 3, 4, 5, 6, 7, 8, 9 };
            Fun5 fun5 = (int[] x) =>
            {
                int buf = arr[0];
                for (int i = 0; i < x.Length; i++)
                    if (buf < arr[i])
                        buf = arr[i];
                return buf;
            };
            Console.WriteLine(fun5(arr));
            #endregion

            #region 6
            Fun6 fun6 = (int[] x) =>
            {
                int buf = arr[0];
                for (int i = 0; i < x.Length; i++)
                    if (buf > arr[i])
                        buf = arr[i];
                return buf;
            };
            Console.WriteLine(fun6(arr));
            #endregion

            #region 7
            Fun7 fun7 = (int[] x) =>
            {
                for (int i = 0; i < x.Length; i++)
                    if (x[i] % 2 != 0)
                        Console.Write(x[i] + " ");
                Console.WriteLine();
            };
            fun7(arr);
            #endregion
        }
    }
}
