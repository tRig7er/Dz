
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №17");
            Console.WriteLine("Выполнил Жуков Артём");
            Console.WriteLine("Вариант 5");
            List<Worker> Employees = new List<Worker>();
            StreamReader streamReader = new StreamReader(@"input.txt", Encoding.UTF8);
            while (!streamReader.EndOfStream)
            {


                string line = streamReader.ReadLine();
                string[] items = line.Split(';');
                Worker Employer = new Worker()
                {
                    NameWorker = items[0].Trim(),
                    PostWorker = items[1].Trim(),
                    YearAccesses = int.Parse(items[2].Trim()),
                };
                Employees.Add(Employer);

                if (Employer.YearAccesses >= 2016 && Employer.YearAccesses <= 2018)
                {
                    Console.WriteLine(Employer.PrintInfo());
                    Employer.Save();
                }
                else if (Employer.YearAccesses >= 2018 && Employer.YearAccesses <= 2020)
                {
                    Console.WriteLine(Employer.PrintInfo());
                    Employer.Save();
                }
                else if (Employer.YearAccesses >= 2020)
                {
                    Console.WriteLine(Employer.PrintInfo());
                    Employer.Save();
                }
                Console.ReadKey();
            }
        }
    }
}
