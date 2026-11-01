Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Назвіть фігуру для розрахунку площі:");
string figure = Console.ReadLine();
figure = figure.ToLower();
if (figure == "квадрат")
{
    Console.WriteLine("Вкажіть довжину сторони:");
    string side = Console.ReadLine();
    side = side.Replace(".", ",");
    double x = double.Parse(side);
    double area = x * x;
    Console.WriteLine($"Площа: {area}");
}
else if (figure == "круг")
{
    Console.WriteLine("Вкажіть радіус:");
    string radius = Console.ReadLine();
    radius = radius.Replace(".", ",");
    double x = double.Parse(radius);
    double area = Math.PI * Math.Pow(x, 2);
    Console.WriteLine($"Площа: {area}");
}
else if (figure == "прямокутник")
{
    Console.WriteLine("Вкажіть ширину:");
    string width = Console.ReadLine();
    width = width.Replace(".", ",");
    double x = double.Parse(width);

    Console.WriteLine("Вкажіть довжину:");
    string length = Console.ReadLine();
    length = length.Replace(".", ",");
    double y = double.Parse(length);

    double area = x * y;

    Console.WriteLine($"Площа: {area}");
}
else if (figure == "трикутник")
{
    Console.WriteLine("Вкажіть висоту:");
    string height = Console.ReadLine();
    height = height.Replace(".", ",");
    double x = double.Parse(height);

    Console.WriteLine("Вкажіть основу:");
    string triangleBase = Console.ReadLine();
    triangleBase = triangleBase.Replace(".", ",");
    double y = double.Parse(triangleBase);

    double area = x * y / 2;

    Console.WriteLine($"Площа: {area}");
}
else
{
    Console.WriteLine("Виберіть іншу фігуру для розрахунку. Наприклад: квадрат, круг, прямокутник, трикутник.");
}