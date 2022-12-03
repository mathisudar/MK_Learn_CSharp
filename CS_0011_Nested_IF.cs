 class ConsoleApp_cs_nested_if
    {
        static void Main(string[] args)
        {
                int marks = 34;
                char grade;

        if (marks >= 35)
        {
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
            else 
            {
                grade = 'C';
                System.Console.WriteLine("Congratulations!, PASS with grade: " + grade);
            }
  

        }
        else
        {
            grade = 'F'; // FAIL
            System.Console.WriteLine("Better luck next time!,FAIL with grade: " + grade);
        }


        System.Console.ReadKey();

        }
 }


    

