using System;

namespace String 
{
    internal class Program
    {
        public void TestInput()
        {
            string a = " TraN  thanh hoA ";
            string b = "Loc";
            a = a.Trim();
            //Console.WriteLine(string.Concat(a, b)); 
            //Console.WriteLine(string.Compare(a, b));
            //Console.WriteLine(a.IndexOf("n"));

            while(a.IndexOf("  ")!= -1)
            {
                a = a.Replace("  ", " ");
            }
           
            string [] Name = a.Split(' ');
            string result = "";
            for (int i = 0; i < Name.Length; i++)
            {
                Name[i] = Name[i].Substring(0,1).ToUpper() + Name[i].Substring(1).ToLower();
                result += Name[i] + " ";
            }

            Console.WriteLine(result);
            Console.WriteLine(string.Concat(result, b));
        }

        public void TestFormat()
        {
            string x = "Hoa Anh Dao";
            int a = 100;
            string z = string.Format("Dac Diem: {0} + {1}", x, a);
            Console.WriteLine(z);
            Console.WriteLine(a.GetType());

            string n = @"Test chuoi voi @\a\c\t\n
                          tren 2 dong";
            Console.Write(n);
            Console.WriteLine("");
            int l = 10;
            int m = 5;
            string toan = $"Ta co {l} / {m} = {l / m}";
            Console.WriteLine(toan);

            Console.WriteLine("Test Vong lap chan le: ");
            string res = "";
            for (int i = 0; i < 10; i++) 
            {
                res = (i % 2 == 0) ? "Chan" : "Le";
                Console.WriteLine($"{i} la {res}");
            }
        }


        static void Main(string[] args)
        {
            Program v = new Program();
            v.TestInput();
            v.TestFormat();
        }
    }
}