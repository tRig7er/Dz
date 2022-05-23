using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR17
{
    class Worker
    {
        string nameWorker;
        string postWorker;
        int yearAccesses;
        public string NameWorker
        {
            get { return nameWorker; }
            set { nameWorker = value; }
        }
        public string PostWorker
        {
            get { return postWorker; }
            set { postWorker = value; }
        }
        public int YearAccesses
        {
            get { return yearAccesses; }
            set { yearAccesses = value; }
        }
        public Worker()
        {
            nameWorker = "";
            postWorker = "";
            yearAccesses = 0;
        }
        public Worker(string name, string post, int Acess)
        {
            nameWorker = name;
            postWorker = post;
            yearAccesses = Acess;
        }
        public string PrintInfo()
        {
            return $"ФИО: {nameWorker} " +
                $"Профессия: {postWorker} " +
                $"Год поступления: {yearAccesses} ";
        }
        public void New_Student()
        {
            Console.WriteLine("Введите фамилию и инициалы студента");
            this.nameWorker = Console.ReadLine();
            Console.WriteLine("Введите группу студента");
            this.postWorker = Console.ReadLine();
            Console.WriteLine("Введите оценку по математике ");
            this.yearAccesses = int.Parse(Console.ReadLine());
        }
        public void InputFromFile(StreamReader sr)
        {
            string input = sr.ReadLine();
            string[] division = input.Split(';');
            nameWorker = division[0];
            postWorker = division[1];
            yearAccesses = int.Parse(division[2]);
        }
        public void Save()
        {
            StreamWriter sr = new StreamWriter(@"Result.txt", false);
            sr.WriteLine($"{nameWorker},{postWorker},{yearAccesses}.");
            sr.Close();
            Console.WriteLine("Сохранение было произведено");
        }
    }
}
