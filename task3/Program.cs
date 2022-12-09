// Задача 23 Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int n = Convert.ToInt32 (Console.ReadLine());
if (n > 0)
{ 
     for (int i = 1; i <= n; i++)
     {
         Console.Write($"{i*i*i} ");
     }
    
}
else 
    Console.Write("Это не натуральное число");