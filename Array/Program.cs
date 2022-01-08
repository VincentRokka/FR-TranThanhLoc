using System;
using System.Collections.Generic;
using System.Linq;

namespace Array
{
    public class Program
    {
		public void EnterArray(ref int[] a, ref int n)
		{
			Console.WriteLine("Enter Full Array: ");
			for (int i = 0; i < n; i++)
			{
				Console.WriteLine("arr[{0}] =", i);
				a[i] = int.Parse(Console.ReadLine());
			}
		}

		public void OutArray(int[] a, int n)
		{
			Console.WriteLine("OutPut Array: ");
			for (int i = 0; i < n; i++)
				Console.Write("{0}" + " ", a[i]);
			Console.WriteLine(" ");
		}

		public void SortUp(ref int[] a, int n)
		{
			for (int i = 0; i < n; i++)
				for (int j = i + 1; j < n; j++)
				{
					if (a[i] > a[j])
					{
						int tmp = a[i];
						a[i] = a[j];
						a[j] = tmp;
					}
				}
		}

		public void SortDown(ref int[] a, int n)
		{
			for (int i = 0; i < n; i++)
				for (int j = i + 1; j < n; j++)
				{
					if (a[i] < a[j])
					{
						int tmp = a[i];
						a[i] = a[j];
						a[j] = tmp;
					}
				}
		}

		public void DelElement(ref int[] a, ref int n, int k)
		{
			if (k > 0 && k <= n)
			{
				for (int i = k - 1; i < n - 1; i++)
					a[i] = a[i + 1];
				n--;
			}
			else
				Console.WriteLine("Position k do not exist!");
		}

		public void Compare(int [] a, int [] b, int n)
        {
			int count = 0;
			for (int i = 0; i < n; i++)
				if (a[i] != b[i])
					count ++;

			if (count == 0)
				Console.WriteLine("true");
			else
				Console.WriteLine("false");
        }

		public static void Main()
		{
            int n;
            do
            {
                Console.WriteLine("Enter n(0<n<10000): ");
                n = int.Parse(Console.ReadLine());
                if (n <= 0 || n >= 10000)
                    Console.WriteLine("Please ReEnter n (0<n<10000):");
            } while (n <= 0 || n >= 10000);
            int[] a = new int[n];

            Program arr = new Program();
            arr.EnterArray(ref a, ref n);
            arr.OutArray(a, n);

            arr.SortUp(ref a, n);
            Console.WriteLine("Array after SortUp: ");
            arr.OutArray(a, n);

            arr.SortDown(ref a, n);
            Console.WriteLine("Array after SortDown: ");
            arr.OutArray(a, n);

            int k;
            Console.WriteLine("Enter k Position to Del: ");
            k = int.Parse(Console.ReadLine());
            arr.DelElement(ref a, ref n, k);
            Console.WriteLine("Array after Del k Position: ");
            arr.OutArray(a, n);

            int[] b = new int[n];
            arr.EnterArray(ref b, ref n);
            arr.Compare(a, b, n);

            int x, y;
			Console.WriteLine("~Two Dimensional Array~");
			Console.WriteLine("Enter x: ");
			x = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter y: ");
			y = int.Parse(Console.ReadLine());

			TwoDimensional v = new TwoDimensional();
			int[,] arr2 = new int[x, y];
			Console.WriteLine("Enter Two Dimentional Array: ");
			v.Enter2(ref arr2, ref x, ref y);
			v.Ouput2(arr2, x, y);
		}
	}
}