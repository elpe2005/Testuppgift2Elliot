    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Här kan du omvandla från celsius till fahrenheit eller tvärtom");
            Console.WriteLine(CtillF);
            Console.WriteLine("Välj mellan 1 och 2.");
        }
        static int CtillF(int Celsius)
        {
            int F = ((32 + Celsius * 1.8));
        }
        static int tal(int Celsius,int F)
        {
            switch (tal)
            {
                case 1:
                    Console.WriteLine("Skriv två tal här nere så omvandlar du celsius till fahrenheit");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Skriv två tal här nere så omvandlar du Fahrenheit till Celsius");
                    Console.ReadLine();
                    break ;
            }
        }
    }
}
