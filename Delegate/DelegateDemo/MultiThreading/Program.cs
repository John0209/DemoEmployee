namespace FptEdu.MultiThreading;
public class Printer
{
    public void PrintNumbers()
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} is running...");
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Value is {i}");
            Thread.Sleep(3000);// cho sleep 1s
        }
        Console.WriteLine();
    }
    public class program
    {
        public static void Main()
        {
            //1. lấy tên luồng chính 
            Thread primaryThread= Thread.CurrentThread;
            primaryThread.Name = "Primary Thread";
           // Console.WriteLine($"{primaryThread.Name} is running in Main method");
            Printer p = new Printer();
            Thread secondThread = new Thread(new ThreadStart(p.PrintNumbers));
            secondThread.Name = "TheSecond Thread";
            secondThread.Start();
            //2. tip tuc cho threaed chính làm
            Console.WriteLine($"{Thread.CurrentThread.Name} is running...Hi");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                Thread.Sleep(1000);// cho sleep 1s
            }
            Console.WriteLine($"Main thread done!...");

        }
    }
}