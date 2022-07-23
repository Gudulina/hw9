/*
Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"
*/

int InputNumbers(string text)
{
    Console.Write(text);
    int temp = int.Parse(Console.ReadLine());
    return temp;
}


int EvenNumbers(int m, int n)
{
  int temporary = m;
  if (temporary > n)
    {
      m = n;
      n = temporary;
    }
  int count = m;
  while (count <= n)    
    if (count % 2 == 0)
      {
        Console.Write($"{count}, ");
        count++);
      }
  return;
}


int m = InputNumbers("Введите число M: ");
int n = InputNumbers("Введите число N: ");

EvenNumbers(m, n);

Console.WriteLine($"{m}, {n}");
