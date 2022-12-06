namespace TinhGiaiThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 1 so tu nhien bat ki: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            if (a>=0)
            {
                for (int i = 1; i <= a; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("Giai thua cua so tu nhien {0} la : {1}",a, factorial);
            } else
            {
                Console.WriteLine("Day khong phai so tu nhien");
            }
            
        }
    }
}