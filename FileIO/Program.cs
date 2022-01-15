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
                    string line = "";
                    while ((line = z.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                    z.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("File Could Not Be Found");
                Console.WriteLine(ex.Message);
            }
        }

        public static void CreateFileBinary(string fileName)
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

            //using (StreamReader readFile = new StreamReader(fileName))
            //{
            //    for (int i = 0; i < 20; i++)
            //        Console.WriteLine(readFile.ReadLine());
            //    readFile.Close();
            //}
        }

        public static void BinaryFileTest(string fileName)
        {
            BinaryWriter bw;
            BinaryReader br;
            int a = 120;
            string z = "Mina San!";
            //try
            //{
            //    bw = new BinaryWriter(new FileStream(fileName, FileMode.Create));
            //    bw.Write(a);
            //    bw.Write(z);
            //    bw.Close();
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.Message + "File Cannot be found");
            //}
            
            Console.WriteLine("Read File Binary: ");
            try
            {
                br = new BinaryReader(new FileStream(fileName,FileMode.Open));
                int at = br.ReadInt32();
                Console.WriteLine("Data a read: " + at);
                string zt = br.ReadString();
                Console.WriteLine("Data z read: " + zt);

                br.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message + "File Cannot be Found (2)");
            }

        }

        public static void Main(string[] args)
        {
            WriteAndReadTextFile("ThirdFileWriteAndRead.txt");

            ReadFileTest("NoFile.txt");
            Console.WriteLine("New Turn: ");
            ReadFileTest("ThirdFileWriteAndRead.txt");
            Console.WriteLine("Turn 3: ");
            BinaryFileTest("BinaryFile1.txt");
            BinaryFileTest("BinaryFile2.txt");
        }
    }
}