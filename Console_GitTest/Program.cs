// See https://aka.ms/new-console-template for more information
using Console_GitTest.StringHelper;

Console.WriteLine("Hello, World!");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{i}. Erol\n");
}


List<int> listInt = new()
{
   1,
   2,
   3
};
foreach (var item in listInt)
{
    Console.WriteLine($"{item}.ci satır");
}

string aa = "besggiktass";
int aa2 = StringManipulation.Without_Repeated_Chars_Longest_Substring(aa);

string aa3 = StringManipulation.LongestPalindromSubstring("babad");

string[] vs = new string[] 
             { "aca", "cba" };
             //{ "dower", "flow", "hight"};
string aa4 = StringManipulation.LongestCommonPrefix(vs);

var _Array = new int[3] { 3, 2, 4 };

int[] vs1 = StringManipulation.TwoSum(_Array, 6);

//
var _Array2 = new int[] { 1, 2, 2, 1 };
var _array3 = new int[] { 2, 2 };
int[] vs2 = StringManipulation.Intersection(_Array2, _array3);

//string aaaa = StringManipulation.IntToRoman(3); //1994

/*test1 branch i açıldı*/


Console.WriteLine(aa2);
Console.Read();