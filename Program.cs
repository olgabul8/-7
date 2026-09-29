string s =  Console.ReadLine();
char t = Convert.ToChar(Console.ReadLine());
string[] words = s.Split(t);
foreach (string x in words)
    Console.WriteLine(x);