using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("---> Розв'язання квадратного рівняння <---");

while (true)
{
    Console.Write("Введіть коефіцієнт a: ");
    bool isA = double.TryParse(Console.ReadLine(), out double a);

    Console.Write("Введіть коефіцієнт b: ");
    bool isB = double.TryParse(Console.ReadLine(), out double b);

    Console.Write("Введіть коефіцієнт c: ");
    bool isC = double.TryParse(Console.ReadLine(), out double c);

    if (!isA || !isB || !isC)
    {
        Console.WriteLine("Введено некоректні дані!");
        Console.WriteLine("Бажаєте спробувати ще раз? (Y - так, будь-яка інша клавіша - вихід)");

        // true означає у сігнатурі методу "перехопити натискання і НЕ виводити його на екран"
        var key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.Y)
        {
            continue; 
        }
        else
        {
            Console.WriteLine("Завершення програми!");
            return; 
        }
    }

    // Якщо дійшли сюди, значить TryParse всюди дав true і можна перейти до основної логіки програми 
    if (a == 0)
    {
        Console.WriteLine("Це не квадратне рівняння (a=0)!");
    }
    else
    {
        double D = (b * b) - (4 * a * c);
        Console.WriteLine($"Дискримінант: {D}");

        if (D > 0)
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);
            Console.WriteLine($"x1 = {x1:F2}, x2 = {x2:F2}");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"x = {x:F2}");
        }
        else
        {
            Console.WriteLine("Коренів немає (D<0)!");
        }
    }

    break; // Успішний кінець роботи
}