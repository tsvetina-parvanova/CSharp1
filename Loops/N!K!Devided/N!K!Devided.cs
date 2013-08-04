using System;

class NFacktKFackt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter first number");
        decimal numberN = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter first number");
        decimal numberK = int.Parse(Console.ReadLine());
        decimal change;
        if(numberN>numberK)
        { 
            change=numberN;
            numberN=numberK;
            numberK=change;
        }
        decimal FacktN=1;
        for (decimal i = 1; i <= numberN; i++)
        {
            FacktN = FacktN * i;
        }

        decimal result = 1;
        for (decimal i = 0; i < (numberK - (numberK - numberN)); i++)
        {
            result = result * (numberK - i);
        }

        Console.WriteLine(FacktN * result);
    }
}
