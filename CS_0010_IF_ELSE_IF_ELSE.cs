 class ConsoleApp_cs_if_elseIF_else
    {
        static void Main()
        {
        int marks = 30;
        char grade;

        if (marks >= 80)
        {
            grade = 'A';
            System.Console.WriteLine("Congratulations!, PASS with grade: " + grade);
        }
        else if (marks >= 60 && marks < 80)
        {
            grade = 'B';
            System.Console.WriteLine("Congratulations!, PASS with grade: " + grade);
        }
        else if (marks >= 40 && marks < 60)
        {
            grade = 'C';
            System.Console.WriteLine("Congratulations!, PASS with grade: " + grade);
        }

        else
        {
            grade = 'F'; // FAIL
            System.Console.WriteLine("Better luck next time!,FAIL with grade: " + grade);
        }

        
        System.Console.ReadKey();

        }
    }

