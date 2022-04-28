// See https://aka.ms/new-console-template for more information
Console.Write("Enter a string:\t");
string str = Console.ReadLine();

char [] ch = new char [str.Length];
for (int i = 0; i < str.Length; i++)
{
ch[i] = str[i];
}

Array.Reverse(ch);

foreach (char i in ch)
{
Console.Write(i+" ");
}
