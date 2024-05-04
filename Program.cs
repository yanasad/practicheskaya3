namespace pract3lit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int zn;
            int c;
            Console.WriteLine("введите число а:");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("введите число б:");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("введите знак:");
            zn = Convert.ToChar(Console.ReadLine());
            if (zn == '+')
            {
                 c = a + b;
                Console.WriteLine("итог: " + c);
            }
            if (zn == '-')
            {
                c = a - b;
                Console.WriteLine("итог: " + c);
            }
            if (zn == '*')
            {
                c = a * b;
                Console.WriteLine("итог: " + c);
            }

            if (zn == '/')
            {
                c = a / b;
                Console.WriteLine("итог: " + c);


            }
        }
}
