
using System.
using System.Threading;
using System.Threading.Tasks;

                //Многопоточность..
//static void Main(string[] args)
//{
//    получаем текущий поток
//   Thread t = Thread.CurrentThread;

//    получаем имя потока
//    Console.WriteLine($"Имя потока: {t.Name}");
//    t.Name = "Метод Main";
//    Console.WriteLine($"Имя потока: {t.Name}");

//    Console.WriteLine($"Запущен ли поток: {t.IsAlive}");
//    Console.WriteLine($"Приоритет потока: {t.Priority}");
//    Console.WriteLine($"Статус потока: {t.ThreadState}");

//    получаем домен приложения
//    Console.WriteLine($"Домен приложения: {Thread.GetDomain().FriendlyName}");

//    Console.ReadLine();
//}
// Асинхронное программирование

//{
//    static void Factorial()
//    {
//        int result = 1;
//        for (int i = 1; i <= 6; i++)
//        {
//            result *= i;
//        }
//        Thread.Sleep(8000);
//        Console.WriteLine($"Факториал равен {result}");
//    }
//    // определение асинхронного метода
//    static async void FactorialAsync()
//    {
//        Console.WriteLine("Начало метода FactorialAsync"); // выполняется синхронно
//        await Task.Run(() => Factorial());                // выполняется асинхронно
//        Console.WriteLine("Конец метода FactorialAsync");
//    }

//    static void Main(string[] args)
//    {
//        FactorialAsync();   // вызов асинхронного метода

//        Console.WriteLine("Введите число: ");
//        int n = Int32.Parse(Console.ReadLine());
//        Console.WriteLine($"Квадрат числа равен {n * n}");

//        Console.Read();
//    }
//}

//Параллельное программирование

//class Program
//{
//    static void Main(string[] args)
//    {
//        Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
//        task1.Start();

//        Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));

//        Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));

//        Console.ReadLine();
//    }
//}
