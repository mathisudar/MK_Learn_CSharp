class primitiveTypeApp
{
    static void Main()
    {
        byte b1_byte = byte.MaxValue;
        byte b2_byte = byte.MinValue;

        sbyte s1_sbyte = sbyte.MaxValue;
        sbyte s2_sbyte = sbyte.MinValue;

        short s1_short = short.MaxValue;
        short s2_short = short.MinValue;

        ushort u1_ushort = ushort.MaxValue;
        ushort u2_ushort = ushort.MinValue;

        int i1_int = int.MaxValue;
        int i2_int = int.MinValue;

        uint u1_uint = uint.MaxValue;
        uint u2_uint = uint.MinValue;

        long l1_long = long.MaxValue;
        long l2_long = long.MinValue;

        ulong u1_ulong = ulong.MaxValue;
        ulong u2_ulong = ulong.MinValue;

        float f1_float = float.MaxValue;
        float f2_float = float.MinValue;
        float f3_float = 200.0f; // f

        double d1_double = double.MaxValue;
        double d2_double = double.MinValue;
        double d3_double = 200.0d; // d

        decimal d1_decimal = decimal.MaxValue;
        decimal d2_decimal = decimal.MinValue;
        decimal d3_decimal = 200.0m; // m

        char c1_char = char.MaxValue;
        char c2_char = char.MinValue;
        char c3_char = 'A';

        string s1_string = string.Empty;
        string s2_string = "Hello";

        bool b1_bool = true;
        bool b2_bool = false;



        System.Console.WriteLine("Max value Byte:"+ b1_byte);
        System.Console.WriteLine("Min value of Byte:"+ b2_byte);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value Sbyte:"+ s1_sbyte);
        System.Console.WriteLine("Min value of Sbyte:"+ s2_sbyte);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value Short:"+ s1_short);
        System.Console.WriteLine("Min value of Short:"+s2_short);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value ushort:"+ u1_ushort);
        System.Console.WriteLine("Min value of ushort:"+ u2_ushort);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value int:"+ i1_int);
        System.Console.WriteLine("Min value of int:"+ i2_int);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value uint:"+ u1_uint);
        System.Console.WriteLine("Min value of uint:"+ u2_uint);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value long:"+ l1_long);
        System.Console.WriteLine("Min value of long:"+ l2_long);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value ulong:"+ u1_ulong);
        System.Console.WriteLine("Min value of ulong:"+ u2_ulong);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value float:"+ f1_float);
        System.Console.WriteLine("Min value of float:"+ f2_float);
        System.Console.WriteLine("Float value:"+ f3_float);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value double:"+ d1_double);
        System.Console.WriteLine("Min value of double:"+ d2_double);
        System.Console.WriteLine("Double value:"+ d3_double);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value decimal:"+ d1_decimal);
        System.Console.WriteLine("Min value of decimal:"+ d2_decimal);
        System.Console.WriteLine("Decimal value:"+d3_decimal);
        System.Console.WriteLine();

        System.Console.WriteLine("Max value char:" + c1_char);
        System.Console.WriteLine("Min value of char:" + c2_char);
        System.Console.WriteLine("Char value:" + c3_char);
        System.Console.WriteLine();

        System.Console.WriteLine("Empty String:" + s1_string);
        System.Console.WriteLine("String value:" + s2_string);
        System.Console.WriteLine();

        System.Console.WriteLine("Bool1:" + b1_bool);
        System.Console.WriteLine("Bool2:" + b2_bool);
        System.Console.WriteLine();

        System.Console.ReadKey();

    }
}

/* Results:

Max value Byte:255
Min value of Byte:0

Max value Sbyte:127
Min value of Sbyte:-128

Max value Short:32767
Min value of Short:-32768

Max value ushort:65535
Min value of ushort:0

Max value int:2147483647
Min value of int:-2147483648

Max value uint:4294967295
Min value of uint:0

Max value long:9223372036854775807
Min value of long:-9223372036854775808

Max value ulong:18446744073709551615
Min value of ulong:0

Max value float:3.402823E+38
Min value of float:-3.402823E+38
Float value:200

Max value double:1.79769313486232E+308
Min value of double:-1.79769313486232E+308
Double value:200

Max value decimal:79228162514264337593543950335
Min value of decimal:-79228162514264337593543950335
Decimal value:200.0

Max value char:?
Min value of char:
Char value:A

Empty String:
String value:Hello

Bool1:True
Bool2:False

*/

