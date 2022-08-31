internal class Program
{
    private static void Main(string[] args)
    {
        int sayi = Convert.ToInt32(Console.ReadLine());
        
        if(sayi % 2 != 0)
            Console.WriteLine("Weird");
        else if(2<=sayi && sayi<=5 && sayi % 2 == 0)
            Console.WriteLine("Not Weird"); 
        else if(6<=sayi && sayi<=20)
            Console.WriteLine("Weird");
        else
            Console.WriteLine("Not Weird");

    }
}