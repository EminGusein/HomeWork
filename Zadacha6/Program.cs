// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число для проверки: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2 == 0)
{
    Console.WriteLine(num + " - чётное число");
}
else
{
    Console.WriteLine(num + " - нечётное число");
}