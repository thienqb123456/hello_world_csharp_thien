namespace GiaiPhuongTrinhBacNhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            double b = Convert.ToInt32(Console.ReadLine());
            double x;
            if (a != 0)
            {
                x = (0 - b) / a;
                Console.WriteLine("value of x: {0}", x);
            } else
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong Trinh co vo so nghiem!!");
                } else
                {
                    Console.WriteLine("Phuong Trinh vo nghiem!!");
                }
            }
            Console.Read();
        }
    }
}