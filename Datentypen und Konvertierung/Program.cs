Console.WriteLine("Aufgabe 1");

Console.WriteLine(short.MaxValue);
Console.WriteLine(short.MinValue);
/*
    16 Bit
    32767
   -32767
*/

Console.WriteLine(int .MaxValue);
Console.WriteLine(int.MinValue);
/*
 2147483648
-2147483648
*/

Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);

/*
 9223372036854775807
-9223372036854775808
*/

Console.WriteLine(float.MaxValue);
Console.WriteLine(float.MinValue);
/*
 3,4028235E+38
-3,4028235E+38
*/

Console.WriteLine(double.MaxValue);
Console.WriteLine(double.MinValue);
/*
 1,7976931348623157E+308
-1,7976931348623157E+308
*/

Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.MinValue);
/*
79228162514264337593543950335
-79228162514264337593543950335
*/

Console.WriteLine("Aufgabe 2");

Console.WriteLine("Geben sie ihren Vornamen ein!");
Console.ReadLine();
Console.WriteLine("Geben sie ihr Alter ein!");
Console.ReadLine();
Console.WriteLine("Ist C# Sharp die erste Programmiersprache, die sie Lernen?");
Console.ReadLine();

bool erster_spr = true;
Console.WriteLine(erster_spr);

Console.WriteLine("Aufgabe 3");

int DollarZahl = 36;
char Dollar = (char)DollarZahl;



Console.WriteLine("Aufgabe 4");

Console.WriteLine("Geben Sie Die Variable ein!");
string v1_str = Console.ReadLine();

short v1_int = Convert.ToInt16(v1_str);

Console.WriteLine(v1_str);


