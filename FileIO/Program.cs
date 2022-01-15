using System;
using System.IO;

namespace FileIO
{
    class Program
    {
        public static void ReadFileTest(string fileName)
        {
            try
            {
                using (StreamReader z = new StreamReader(fileName))
                {
                    string line = z.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File Could Not Be Found");
                Console.WriteLine(ex.Message);
            }
        }

        public void CreateFileBinary(string fileName)
        {
            using (FileStream z = File.Create(fileName))
            {
                for (int i = 1; i <= 22; i++)
                    z.WriteByte((Byte)i);

                z.Position = 0;

                for (int i = 0; i <= 30; i++)
                    Console.Write(z.ReadByte() + " ");
            }
        }

        public static void WriteAndReadTextFile(string fileName)
        {
            using (StreamWriter writeFile = new StreamWriter(fileName))
            {
                for (int i = 0; i < 20; i++)
                    writeFile.WriteLine(i.ToString());
                writeFile.Close();
            }

            using (StreamReader readFile = new StreamReader(fileName))
            {
                for (int i = 0; i < 20; i++)
                    Console.WriteLine(readFile.ReadLine());
                readFile.Close();
            }
        }

        public static void Main(string[] args)
        {
            WriteAndReadTextFile("ThirdFileWriteAndRead.txt");

            ReadFileTest("NoFile.txt");
            Console.WriteLine("New Turn: ");
            ReadFileTest("zz.txt");
        }
    }
}