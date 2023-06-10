/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.Clear();
Console.Write("Сколько чисел хотите ввести: ");
int n = int.Parse(Console.ReadLine()!);
int i = 1;
int res = 0;
while(i < n)
{
    Console.Write($"Введите {i} число: ");
    int m = int.Parse(Console.ReadLine()!);
    if (m > 0)
        res = res + 1;
    i++;  
}
Console.Write($"Введено {res} положительных чисел(a)");