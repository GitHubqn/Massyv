using System.ComponentModel.DataAnnotations;

class xand0
{
    public static double Sum(double[] mass)
    {
        double res = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            res += mass[i];
        }
        return res;
    }
    public static double Sum(double[,] mass)
    {
        double res = 0;
        for (int j = 0; j < 5; j++)
        {
            for (int i = 0; i < 5; i++)
            {
                res += mass[i,j];
            }
        }
        return res;
    }

    public static double Sred(double[] mass)
    {
        double res = 0;
        res = Sum(mass) / mass.Length;
        return res;
    }
    public static double Sred(double[,] mass)
    {
        double res = 0;
        res = Sum(mass) / mass.Length;
        return res;
    }

    public static double Min(double[] mass)
    {
        double min = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] < min) {  min = mass[i]; }
        }
        return min;
    }
    public static double Min(double[,] mass)
    {
        double min = 999999;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (mass[i,j] < min) { min = mass[i,j]; }
            }
        }
        return min;
    }

    public static double Max(double[] mass)
    {
        double max = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            if (mass[i] > max) { max = mass[i]; }
        }
        return max;
    }
    public static double Max(double[,] mass)
    {
        double max = 0;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (mass[i, j] > max) { max = mass[i, j]; }
            }
        }
        return max;
    }

    public static double Repeat(double[] mass)
    {
        double min = 0;
        for (int i = 0; i < mass.Length; i++)
        {
            
        }
        return min;
    }


    static void Main()
    {
        Random rnd = new Random();

        double[] Mass1 = new double[10];

        for (int i = 0; i < Mass1.Length; i++)
        {
            Mass1[i] = rnd.Next(0, 10);
            Console.Write(Mass1[i] + "|");
        }
        Console.WriteLine("\n====================");


        double[,] Mass2 = new double[5,5];

        for (int i = 0; i < 5; i++) 
        { 
            for (int j = 0; j < 5; j++) 
            {
                Mass2[i,j] = rnd.Next(0,10);
                Console.Write(Mass2[i, j] + "|");
            }
            Console.WriteLine("");
        }

        Console.WriteLine("Cумма всех чисел одномерного массива = " + Sum(Mass1));
        Console.WriteLine("Cумма всех чисел двумерного массива = " + Sum(Mass2));
        Console.WriteLine("Среднее-арифметическое одномерного массива = " + Sred(Mass1));
        Console.WriteLine("Среднее-арифметическое двумерного массива = " + Sred(Mass2));
        Console.WriteLine("Минимальное одномерного массива = " + Min(Mass1));
        Console.WriteLine("Минимальное двумерного массива = " + Min(Mass2));
        Console.WriteLine("Максимальное одномерного массива = " + Max(Mass1));
        Console.WriteLine("Максимальное двумерного массива = " + Max(Mass2));
    }
}
