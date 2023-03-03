// Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)). Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода слова "stop".

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string userString = "";
int count = 0;

do
{
    Console.WriteLine("Введите любую строку и нажмите клавишу Enter: ");
    userString = Console.ReadLine();
    int value = Convert.ToInt32(userString);

    if (value > 0)
    {
        count = count +1;
    }
    Console.WriteLine(count);
} while (userString != "stop");




 
