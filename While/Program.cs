using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("---> 2+3 чи !99? <---");

Console.Write("Введіть натуральне число n: ");

if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
{
    Console.WriteLine($"Результати для n = {n}:");

    double resultFor = CalculateWithFor(n);
    Console.WriteLine($"Вираз a = {resultFor}");

    double resultWhile = CalculateWithWhile(n);
    Console.WriteLine($"Вираз b = {resultWhile}");

    long resultDoWhile = CalculateWithDoWhile(n);
    Console.WriteLine($"Вираз c = {resultDoWhile}");
}
else
{
    Console.WriteLine("Помилка! Діапазон вводу чисел порушено. Бан!");
    return;
}

double CalculateWithFor(int n)
{
    double sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum += Math.Pow(-1, i) / (2 * i + 1);
    }
    return sum;
}

double CalculateWithWhile(int n)
{
    double sum = 0;
    int i = 1;
    while (i <= n)
    {
        sum += 1 + 1d / Math.Pow(i,2);
        i++;
    }
    return sum;
}


long CalculateWithDoWhile(int n)
{
    long sum = 0;
    long factorial = 1; 
    int i = 1;
    do
    {
        factorial *= i; 
        sum += factorial;
        i++;
    } while (i <= n);

    return sum;
}
