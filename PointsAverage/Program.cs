using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

double sum = 0;
int gradesCount = 5;
bool userWantsToExit = false; // Змінна для перевірки бажання вийти

Console.WriteLine("---> Студент допущений до екзамену? <---");
Console.WriteLine($"Введіть {gradesCount} оцінок (0-100)");

for (int i = 1; i <= gradesCount; i++)
{
    double grade = 0;
    bool inputSuccess = false;

    do
    {
        Console.Write($"Оцінка {i}: ");
        string input = Console.ReadLine();

        // Введені дані є числом і у потрібному нам діапазоні?
        if (double.TryParse(input, out grade) && grade >= 0 && grade <= 100)
        {
            inputSuccess = true; 
        }
        else
        {
            Console.WriteLine("Помилка! Введіть число від 0 до 100");
            Console.WriteLine("Натисніть 'Q' для виходу або будь-яку іншу клавішу для повторного введення");

            if (Console.ReadKey(true).Key == ConsoleKey.Q)
            {
                return; 
            }
        }

    } while (!inputSuccess); 

    sum += grade;
}


double average = sum / gradesCount;
Console.WriteLine($"\nСередній бал: {average}");

if (average >= 50)
    Console.WriteLine("Студент допущений до екзамену!");
else
    Console.WriteLine("Студент НЕ допущений до екзамену!");