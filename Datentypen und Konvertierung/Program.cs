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
 * 32 Bit
 2147483648
-2147483648
*/

Console.WriteLine(long.MaxValue);
Console.WriteLine(long.MinValue);

/*
 * 64 Bit
 9223372036854775807
-9223372036854775808
*/

Console.WriteLine(float.MaxValue);
Console.WriteLine(float.MinValue);
/*
* 32 Bit
3,4028235E+38
-3,4028235E+38
*/

Console.WriteLine(double.MaxValue);
Console.WriteLine(double.MinValue);
/*64 Bit
 1,7976931348623157E+308
-1,7976931348623157E+308
*/

Console.WriteLine(decimal.MaxValue);
Console.WriteLine(decimal.MinValue);
/* 128 Bit
79228162514264337593543950335
-79228162514264337593543950335
*/

Console.WriteLine("Aufgabe 2");

string vorname = "ilkan";
short alter = 16;
bool frage = true;

Console.WriteLine("Ihre Antworten:");
Console.WriteLine($"1. {vorname}\n2. {alter}\n3. {frage}");


bool erster_spr = true;
Console.WriteLine(erster_spr);

Console.WriteLine("Aufgabe 3");

/*
int DollarZahl = 36;
char Dollar = (char)DollarZahl;
*/


Console.WriteLine("Aufgabe 4");

Console.WriteLine("Geben Sie Die Variable ein!");
string v1_str = Console.ReadLine();

short v1_int = Convert.ToInt16(v1_str);
