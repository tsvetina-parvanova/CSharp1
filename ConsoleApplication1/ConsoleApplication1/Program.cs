using System;



class NullValues
{
    static void Main()
    {

        double N = double.Parse(Console.ReadLine());
    

       double M = double.Parse(Console.ReadLine());
      double P = double.Parse(Console.ReadLine());
        double numerator = ((N * N) + (1.0 / (M * P)) + 1337.0);
        numerator /= N - (128.523123123 * P);



        int mod = (int)M % 180;
       double sin = Math.Sin(mod);
      numerator += sin;
       Console.WriteLine("{0:F6}",numerator);
    }
}
