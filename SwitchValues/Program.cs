using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

Console.WriteLine("---> 7 чи вісім? <---");

int number;
// Це число, яке входить у визначені рамки?
while (true){
    Console.Write("Введіть ціле число [0-9]: ");
    if (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 9)
    {
        Console.WriteLine("Помилка! Введіть ціле число від 0 до 9!");
        Console.Write("Спробувати ще раз? (Y - так, будь-яка інша клавіша - вихід)");

        if (Console.ReadKey(true).Key == ConsoleKey.Y)
        {
            Console.WriteLine();
            continue; 
        }
        else
        {
            return; 
        }
    }
    break;
}
switch (number)
{
    case 0: Console.WriteLine("нуль"); break;
    case 1: Console.WriteLine("один"); break;
    case 2: Console.WriteLine("два"); break;
    case 3: Console.WriteLine("три"); break;
    case 4: Console.WriteLine("чотири"); break;
    case 5: Console.WriteLine("п'ять"); break;
    case 6: Console.WriteLine("шість"); break;
    case 7: Console.WriteLine("сім"); break;
    case 8: Console.WriteLine("вісім"); break;
    case 9: Console.WriteLine("дев'ять"); break;
}

            