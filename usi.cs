
using System.
using System.Threading;
using System.Threading.Tasks;

                //���������������..
//static void Main(string[] args)
//{
//    �������� ������� �����
//   Thread t = Thread.CurrentThread;

//    �������� ��� ������
//    Console.WriteLine($"��� ������: {t.Name}");
//    t.Name = "����� Main";
//    Console.WriteLine($"��� ������: {t.Name}");

//    Console.WriteLine($"������� �� �����: {t.IsAlive}");
//    Console.WriteLine($"��������� ������: {t.Priority}");
//    Console.WriteLine($"������ ������: {t.ThreadState}");

//    �������� ����� ����������
//    Console.WriteLine($"����� ����������: {Thread.GetDomain().FriendlyName}");

//    Console.ReadLine();
//}
// ����������� ����������������

//{
//    static void Factorial()
//    {
//        int result = 1;
//        for (int i = 1; i <= 6; i++)
//        {
//            result *= i;
//        }
//        Thread.Sleep(8000);
//        Console.WriteLine($"��������� ����� {result}");
//    }
//    // ����������� ������������ ������
//    static async void FactorialAsync()
//    {
//        Console.WriteLine("������ ������ FactorialAsync"); // ����������� ���������
//        await Task.Run(() => Factorial());                // ����������� ����������
//        Console.WriteLine("����� ������ FactorialAsync");
//    }

//    static void Main(string[] args)
//    {
//        FactorialAsync();   // ����� ������������ ������

//        Console.WriteLine("������� �����: ");
//        int n = Int32.Parse(Console.ReadLine());
//        Console.WriteLine($"������� ����� ����� {n * n}");

//        Console.Read();
//    }
//}

//������������ ����������������

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
