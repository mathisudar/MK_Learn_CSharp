class RoundUp
{
    static void Main()
    {
        int input1 = 499;
        int input2 = 500;
        int input3 = 999;
        int input4 = 1000;
        int input5 = 1499;
        int input6 = 1500;


        int output1 = (input1 >= 499 & input1 <= 1499) ? output1 = 1000 : 
            (input1 > 1499 & input1 < 2000) ? output1 = 2000 : output1 = 0;

        int output2 = (input2 >= 499 & input2 <= 1499) ? output2 = 1000 :
            (input2 > 1499 & input2 < 2000) ? output2 = 2000 : output2 = 0;

        int output3 = (input3 >= 499 & input3 <= 1499) ? output3 = 1000 :
            (input3 > 1499 & input3 < 2000) ? output3 = 2000 : output3 = 0;

        int output4 = (input4 >= 499 & input4 <= 1499) ? output4 = 1000 :
           (input4 > 1499 & input4 < 2000) ? output4 = 2000 : output4 = 0;
        
        int output5 = (input5 >= 499 & input5 <= 1499) ? output5 = 1000 :
          (input5 > 1499 & input5 < 2000) ? output5 = 2000 : output5 = 0;
        
        int output6 = (input6 >= 499 & input6 <= 1499) ? output6 = 1000 :
          (input6 > 1499 & input6 < 2000) ? output6 = 2000 : output6 = 0;



        System.Console.WriteLine("input: " + input1 + " output:" + output1);
        System.Console.WriteLine("input: " + input2 + " output:" + output2);
        System.Console.WriteLine("input: " + input3 + " output:" + output3);
        System.Console.WriteLine("input: " + input4 + " output:" + output4);
        System.Console.WriteLine("input: " + input5 + " output:" + output5);
        System.Console.WriteLine("input: " + input6 + " output:" + output6);


        System.Console.ReadLine();  


    }
}


/* Results

input: 499 output:1000
input: 500 output:1000
input: 999 output:1000
input: 1000 output:1000
input: 1499 output:1000
input: 1500 output:2000

*/
