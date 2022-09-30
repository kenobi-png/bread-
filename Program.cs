using System;
using System.IO;
namespace readwriteapp
{
    class Program
    { 
        
        static void Main(string[] args)

        {
            Console.WriteLine("Введите число которое вас интересует(1-4): ");
            int search = Convert.ToInt32(Console.ReadLine());
            if (search == 1)
            {
                string searchName = "1";

                using (StreamReader sr = new StreamReader(@"C:\Users\dimas\Desktop\Новая папка\Новая папка\123.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.ToLower().Contains(searchName.ToLower()))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }

            }
           
            if (search == 2)
            {
                string searchName = "Толя";

                using (StreamReader sr = new StreamReader(@"C:\Users\dimas\Desktop\Новая папка\Новая папка\123.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.ToLower().Contains(searchName.ToLower()))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }

            }
            if (search == 3)
            {
                string searchName = "3";

                using (StreamReader sr = new StreamReader(@"C:\Users\dimas\Desktop\Новая папка\Новая папка\123.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.ToLower().Contains(searchName.ToLower()))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }

            }
            if (search == 4)
            {
                string searchName = "4";

                using (StreamReader sr = new StreamReader(@"C:\Users\dimas\Desktop\Новая папка\Новая папка\123.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line.ToLower().Contains(searchName.ToLower()))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
        
    
