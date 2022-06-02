using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {           
        static void Main(string[] args)
        {
            TypeReader typeReader = new TypeReader();
            typeReader.EnteredTypeEvent += Sortt1;
            try
            {
                typeReader.Read();
            }
            catch (FormatException)
            {
                Console.WriteLine("Тип сортировки введен не корректно");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Сортировка завершена!!!");
            }
        }
        static void Sortt1 (int Type)
            {   
                List<string> people = new List<string>();
                people.Add("Иванов");
                people.Add("Петров");
                people.Add("Сидоров");
                people.Add("Пупкин");
                people.Add("Аннов");
                switch (Type)
                {
                    case 1: if (Type == 1) people.Sort();
                           foreach (string item in people) Console.WriteLine(item); break;
                    case 2:if (Type == 2) people.Reverse();
                          foreach (string item in people) Console.WriteLine(item); break;
                }
            }
    }
    class TypeReader
        {
            public delegate void Sort_A_ZDelegate(int Typee);
            public event Sort_A_ZDelegate EnteredTypeEvent;

        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Введите тип сортировки: 1- от А до Я, 2- от Я до А");
            int Typee = Convert.ToInt32(Console.ReadLine());
            if (Typee != 1 && Typee != 2) throw new Exception("Такого типа не существует");
            EnteredType(Typee);
        }
           
        protected virtual void EnteredType(int Typee)
        {
            EnteredTypeEvent?.Invoke(Typee);
        }
        
        }
}
