using System;

namespace chapter2Solutions
{
    class Program
    {
        private static void Cin()
        {
            if (File.Exists("./input.txt"))
            {
                StreamReader cin = new StreamReader("./input.txt");
                Console.SetIn(cin);
            }
        }
        private static void Cout()
        {
            if (File.Exists("./output.txt"))
            {
                StreamWriter cout = new StreamWriter("./output.txt");
                Console.SetOut(cout);
                // donotforget to use "Console.Out.Close();" in the end.  
            }
        }
        private static void Solve()
        {
            int weight = int.Parse(Console.ReadLine());
            if (weight > 3 && (weight & 1) == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");

        }
        static void Main()
        {
            Cin(); Cout();
            Solve();
            Console.Out.Close();
        }
    }
}