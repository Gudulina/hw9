/*
Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

Console.Write("Введите первое число больше, чем второе: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine());

void EvenNumbers(int m, int n)
{
  int temp = m;
  if (temp < n)
    {
      m = n;
      n = temp;
      Console.WriteLine ("Вы ввели второе значение больше первого, поэтому программа поменяла числа местами.");
    }
//  if (temp == 0)
//  {
  //  return;
  //}
  if (temp %2 != 0)
  {
    temp--;
  }
  EvenNumbers (m - 2, n);
  if (temp % 2 == 0)
  {
    Console.Write($"{temp}, ");
  }  
}

EvenNumbers(M, N);
