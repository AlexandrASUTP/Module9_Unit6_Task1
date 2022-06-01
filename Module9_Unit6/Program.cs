using System;
using System.IO;


namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
                string Exc1 = "Введенный символ не число!!!";        
                string Exc2 = "Введенное число не соответствует типу byte!!!"; 
                string Exc3 = "Число 1 введено некорректно!!!";
                string Exc4 = "Делить на ноль нельзя!!!";
                string Exc5 = "Такой файл не существует!!!";

                string[] MyException = { Exc1, Exc2, Exc3, Exc4, Exc5 };
            
                try
                {

                    Console.WriteLine("Введите два числа типа byte: первое число должно быть 200");
                    byte number1 = byte.Parse(Console.ReadLine());
                    byte number2 = byte.Parse(Console.ReadLine());
                    int res1 = number1 / number2;
                    int res2 = number1 * number2;
                    Console.WriteLine($"Результат деления 2 чисел: {res1}");
                    Console.WriteLine($"Результат умножения 2 чисел: {res2}");
                    if (number1 == 200) Console.WriteLine("Число введено корректно!!!");
                    else throw new Exception(MyException[2]);                             // мое исключение 
                    Console.WriteLine("Укажите необходимый файл для чтения:");
                    string path = Console.ReadLine();
                    using (StreamReader reader = new StreamReader(path))
                    {
                    reader.ReadToEnd();
                    }

            }
                catch (FormatException)
                {
                    Console.WriteLine(MyException[0]);
                }
                catch (OverflowException)
                {
                    Console.WriteLine(MyException[1]);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine(MyException[3]);
                }
                catch (FileNotFoundException)
                {
                 Console.WriteLine(MyException[4]);
                }
            catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    throw;
                }

                finally
                {
                    Console.WriteLine("Обработка завершена!");
                }
            Console.Read();
        }
            

            
        
    }
}
