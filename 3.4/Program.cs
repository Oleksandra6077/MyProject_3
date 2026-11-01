Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введіть текст:");
string text = Console.ReadLine();
int n = text.Length;
string result = "";
for (int i = 0; i < n; i++)
{
    char symbol = text[i];
    int number = i + 1;

    if (number % 15 == 0)
    {
        Console.Write("?");
    }
    else if (number % 5 == 0)
    {
        Console.Write("9");
    }
    else if (number % 3 == 0)
    {
        Console.Write("x");
    }
    else
    {
        Console.Write(symbol);
    }
}
