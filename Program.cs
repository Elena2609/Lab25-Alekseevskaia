using System.Collections.Generic;
//2. Какие бывают ошибки
// Console.Write("Введите целое число: ");
// int number = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine($"Число: {number}");

//3. Блоки try и catch
// try
// {
//     Console.Write("Введите целое число: ");
//     int number = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine($"Число: {number}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введите целое число");
// }
// Console.WriteLine("Программа продолжает работу");

// //Найдите ошибку: преобразование вне try
// Console.Write("Введите целое число: ");
// try
// {
//     int number = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine(number);
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введите целое число");
// }

//4. Несколько обработчиков
try
{
    Console.Write("Делимое: ");
    int first = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Делитель: ");
    int second = int.Parse(Console.ReadLine() ?? "");
    int result = first / second;
    Console.WriteLine($"Результат: {result}");
}
catch (FormatException)
{
    Console.WriteLine("Ошибка: введите целое число");
}
catch (OverflowException)
{
    Console.WriteLine("Ошибка: число или результат вне диапазона int");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ошибка: деление на ноль");
}

//5. Собственная проверка и throw
// void AddScore(List<int> scores, int score)
// {
//     if (score < 0 || score > 100)
//     {
//         throw new ArgumentOutOfRangeException(
//         nameof(score), "Результат должен быть от 0 до 100");
//     }
//     scores.Add(score);
// }

// List<int> testScores = new List<int>();
// try
// {
//     AddScore(testScores, 80);
//     AddScore(testScores, -5);
//     AddScore(testScores, 90);
// }
// catch (ArgumentOutOfRangeException)
// {
//     Console.WriteLine("Ошибка: результат должен быть от 0 до 100");
// }
// Console.WriteLine($"Сохранено результатов: {testScores.Count}");

//Найдите ошибку: изменение до проверки
void AddScore(List<int> scores, int score)
{
    scores.Add(score);
    if (score < 0 || score > 100){
    throw new ArgumentOutOfRangeException(nameof(score));
    }
}
