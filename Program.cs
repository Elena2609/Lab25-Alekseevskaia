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
// try
// {
//     Console.Write("Делимое: ");
//     int first = int.Parse(Console.ReadLine() ?? "");
//     Console.Write("Делитель: ");
//     int second = int.Parse(Console.ReadLine() ?? "");
//     int result = first / second;
//     Console.WriteLine($"Результат: {result}");
// }
// catch (FormatException)
// {
//     Console.WriteLine("Ошибка: введите целое число");
// }
// catch (OverflowException)
// {
//     Console.WriteLine("Ошибка: число или результат вне диапазона int");
// }
// catch (DivideByZeroException)
// {
//     Console.WriteLine("Ошибка: деление на ноль");
// }

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
// void AddScore(List<int> scores, int score)
// {
//     if (score < 0 || score > 100)
//     {
//         throw new ArgumentOutOfRangeException(nameof(score));
//     } 
//     scores.Add(score);
// }

// List<int> testScores = new List<int>();

// try
// {
//     AddScore(testScores, 0);
//     AddScore(testScores, 100);
// }
// catch (ArgumentOutOfRangeException)
// {
//     Console.WriteLine("Ошибка: результат должен быть от 0 до 100");
// }

// try
// {
//     AddScore(testScores, -5);
// }
// catch (ArgumentOutOfRangeException)
// {
//     Console.WriteLine("Ошибка: -5 отклонён");
// }

// try
// {
//     AddScore(testScores, 101);
// }
// catch (ArgumentOutOfRangeException)
// {
//     Console.WriteLine("Ошибка: 101 отклонён");
// }

// Console.WriteLine($"Сохранено результатов: {testScores.Count}");

//6. Блок finally
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
// catch (OverflowException)
// {
//     Console.WriteLine("Ошибка: число вне диапозона");
// }
// finally
// {
//     Console.WriteLine("Попытка завершена");
// } 

// //7. Повторный ввод и TryParse()
// Console.Write("Введите целое число: ");
// string input = Console.ReadLine() ?? "";
// if (int.TryParse(input, out int number)){
//     Console.WriteLine($"Число: {number}");
// }
// else
// {
//     Console.WriteLine("Не удалось прочитать целое число");
// }

//Ввод количества результатов
// int ReadCount()
// {
//     while (true)
//     {
//         Console.Write("Сколько результатов сохранить (0-10): ");
//         string input = Console.ReadLine() ?? "";

//         if (int.TryParse(input, out int count) && count >= 0 && count <= 10)
//         {
//             return count;
//         }
//         Console.WriteLine("Введите целое число от 0 до 10");
//     }
// }

// int count = ReadCount();
// Console.WriteLine($"Получено количество: {count}");

//Найдите ошибку: результат TryParse() проигнорирован
string input = "0";
if (int.TryParse(input, out int number))
{
    Console.WriteLine($"Принято число: {number}");
}
else
{
    Console.WriteLine("Не удалось прочитать целое число");
}