 class ConsoleApp_cs_largest_number
    {
        static void Main()
        {
        int numb1 = 60;
        int numb2 = 45;
        int numb3 = 123;

        if (numb3 > numb2 && numb3 > numb1)
        {
            System.Console.WriteLine("Largest Number: " + numb3);
        }
        else if (numb2 > numb3 && numb2 > numb1)
        {
            System.Console.WriteLine("Largest Number: " + numb2);

        }
        else
        {
            System.Console.WriteLine("Largest Number: " + numb1);
        }

        System.Console.ReadLine();

        }
    }

