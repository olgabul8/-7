string s = Console.ReadLine();
char v = Convert.ToChar(Console.ReadLine());
int c = 0;
for (int i = 0; i < s.Length; i++)
{
    if (s[i] == v)
    { c++; }
}
s = s.Replace(v, char.ToUpper(v));
Console.WriteLine(c);
Console.WriteLine(s);