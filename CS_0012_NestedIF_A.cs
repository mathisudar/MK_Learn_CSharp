
    internal class ConsoleApp_cs_height_define
    {
        static void Main()
        {

        double heightInch = 75;
        double heightCM = heightInch * 2.54;

        if (heightCM >= 150)
        {
            if (heightCM >= 150 && heightCM < 165)
            {
                System.Console.WriteLine("Average height");
            }
            if (heightCM >165 && heightCM <= 195)
            {
                System.Console.WriteLine("Tall");
            }
            if (heightCM > 195)
            {
                System.Console.WriteLine("Abnormal height");
            }
        }

        System.Console.ReadKey();

        }
    }

