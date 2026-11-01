Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Введіть число (не менше п'яти цифр): ");
string line = Console.ReadLine();
long n = long.Parse(line);
long result = 0;
int x = line.Length;
if (line[0] == '-')
{
    x--;
}
if (x < 5)
{
    Console.WriteLine("Ви ввели не достатню кількість цифр.");
}
else
{
    while (n != 0)
    {
        long digit = n % 10;
        result = result * 10 + digit;
        n = n / 10;
    }
    Console.WriteLine(result);
}