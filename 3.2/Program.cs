Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть текст:");
string line = Console.ReadLine();
Console.WriteLine("Скільки слів видалити?");
string line1 = Console.ReadLine();
int x = int.Parse(line1);
string[] words = line.Split(' ');
string result = "";
if (x > words.Length)
{
    Console.WriteLine("Помилка. Введіть більший текст або меншу кількість видаленних слів.");
}
else
{
    for (int i = x; i < words.Length; i++)
    {
        result += words[i] + " ";
    }
    result = result.Trim();
    Console.WriteLine(result);
}
