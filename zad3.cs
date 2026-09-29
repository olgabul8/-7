string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
int len = alf.Length;

string word = Console.ReadLine();
int k = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("1 - шифр");
Console.WriteLine("2 - дешифр");
int v = Convert.ToInt32(Console.ReadLine());

string result = "";

foreach (char d in word)
{
    if (alf.Contains(d))
    {
        int i = alf.IndexOf(d);

        if (v == 1)
            i = (i + k) % len;
        else
            i = (i - k + len) % len;

        result += alf[i];
    }
    else
    {
        result += d;
    }
}

Console.WriteLine(result);