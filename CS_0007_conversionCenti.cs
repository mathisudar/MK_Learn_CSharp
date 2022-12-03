class ConversionCenti
{
    static void Main()
    {
        decimal feet = 5M;
        decimal inches = 7M;

        decimal height = (feet * 12M * 2.54M) + (inches * 2.54M);
        System.Console.WriteLine("Height in CentMeter:"+height+" cm");
        System.Console.ReadKey();

    }
}
