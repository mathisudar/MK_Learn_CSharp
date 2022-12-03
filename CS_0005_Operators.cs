class OperatorsApp
{
    static void Main()
    {
        decimal a1 = 10M;
        decimal a2 = 3M;
        decimal a3_add = a1 + a2;
        decimal a3_sub = a1 - a2;
        decimal a3_mul = a1 * a2;
        decimal a3_div = a1 / a2;
        decimal a3_mod = a1 % a2;

        System.Console.WriteLine();
        System.Console.WriteLine("Arithmetic Operators:");
        System.Console.WriteLine("Addition:" + a3_add);
        System.Console.WriteLine("Sub:"+a3_sub);
        System.Console.WriteLine("Mult:"+a3_mul);
        System.Console.WriteLine("Div:"+a3_div);
        System.Console.WriteLine("Remainder:"+a3_mod);




        // Assignment Operators

        System.Console.WriteLine();
        System.Console.WriteLine("Assignment Operators:");
        a1 += 20M;
        System.Console.WriteLine("Inc by 20:"+a1);

        a1 -= 20M;
        System.Console.WriteLine("Dec by 20:"+a1);

        a1 *= 3M;
        System.Console.WriteLine("Multi by 3:"+a1);

        a1 /= 3M;
        System.Console.WriteLine("Div by 3:"+a1);

        a1 %= 3M;
        System.Console.WriteLine ("Remainder:"+a1);



        // Increment and Decrement Operator
        
        System.Console.WriteLine();
        System.Console.WriteLine("Increment Operators:");

        decimal b1 = 10M;

        decimal b2 = ++b1;
        decimal b3 = b1++;
        decimal c1 = --b1;
        decimal c2 = b1--;

        System.Console.WriteLine(b2);
        System.Console.WriteLine(b3);
        System.Console.WriteLine(c1);
        System.Console.WriteLine(c2);
        System.Console.WriteLine(b1);




        // Boolean Operator

        System.Console.WriteLine();
        System.Console.WriteLine("Boolean Operators:");
        bool myB1 = a1 == 10;
        System.Console.WriteLine(myB1);
        bool myB2 = a1 != 10;
        System.Console.WriteLine(myB2);
        bool myB3 = a1 <= 10;
        System.Console.WriteLine(myB3);
        bool myB4 = a1 >= 10;
        System.Console.WriteLine(myB4);



        // Logical Operator

        System.Console.WriteLine();
        System.Console.WriteLine("Logical Operators:");

        decimal condition1 = 10M;
        decimal condition2 = 20M;

        bool resultCondition = condition1 != condition2 & condition1 == condition2;
        System.Console.WriteLine(resultCondition);

        bool resultCondition2 = condition1 <= condition2 & condition1 != condition2;
        System.Console.WriteLine(resultCondition2);

        bool resultCondition3 = condition1 != condition2 | condition1 == condition2;
        System.Console.WriteLine(resultCondition3);

        bool resultCondition4 = !(condition1 != condition2 | condition1 == condition2);
        System.Console.WriteLine(resultCondition4);

        bool resultCondition5 = condition1 <= condition2 ^ condition1 != condition2;
        // Not both conditions are true or false
        System.Console.WriteLine(resultCondition5);




        // Concatenation  Operator


        System.Console.WriteLine();
        System.Console.WriteLine("Concatenation Operators:");

        string fName = " Mathi";
        string lName = " Krishnan";
        string fullName = "Hello"+fName+lName+".";
        System.Console.WriteLine(fullName);


       
        // Ternary  Operator


        System.Console.WriteLine();
        System.Console.WriteLine("Ternary Operators:");

        int age = 20;
        string title = (age < 20) ? "Child" : (age > 10 && age < 20) ? "Teenage" : "Adult";
        System.Console.WriteLine(title);

       

        // Operator Precedence

        System.Console.WriteLine();
        System.Console.WriteLine("Operator Precedence:");

        decimal op1 = 10 + 20 * 2 / 4M;
        System.Console.WriteLine(op1);

        System.Console.ReadKey();




    }
}

/* Results:


Arithmetic Operators:
Addition:13
Sub:7
Mult:30
Div:3.3333333333333333333333333333
Remainder:1

Assignment Operators:
Inc by 20:30
Dec by 20:10
Multi by 3:30
Div by 3:10
Remainder:1

Increment Operators:
11
11
11
11
10

Boolean Operators:
False
True
True
False

Logical Operators:
False
True
True
False
False

Concatenation Operators:
Hello Mathi Krishnan.

Ternary Operators:
Adult

Operator Precedence:
20

*/

