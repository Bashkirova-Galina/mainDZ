// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// string rec(int n)
// {
//     if (n==0)
//          return "";
//      return $"{n}"+rec(n-1);
    
// }

// Console.Write("Введите элемент ");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));




// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// int SumOfElements(int n, int m)
// {
//   if (n == m) return n;
//   else return SumOfElements(n + 1, m) + n;
// }


// Console.Write("Введите элемент ");
// int m=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите элемент ");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumOfElements(m,n));


// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int Prompt(string message)
{
  Console.Write(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  else return Akkerman(m - 1, Akkerman(m, n - 1));
}

int m = Prompt("Input M: ");
int n = Prompt("Input N: ");

Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");