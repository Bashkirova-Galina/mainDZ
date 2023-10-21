//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//int main() {
//     int a, b;
//     int pow = 1;
//      Console.Write("Enter A: ");
//     a =Convert.ToInt32(Console.Readline());
//     Console.Write( "Enter B: ");
//     b=Convert.ToInt32(Console.Readline());
//     for (int i = 0; i < b; i++) {
//        pow*= a;
//     }
//     Console.Write(pow);
//    }

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Write("введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int len = Length(a);
Console.Write($"Сумма цифр в числе {a} равно: {Sum(a,len)}");

// Подсчет количества символов в числе
int Length(int a)
{
int index = 0;
while (a > 0)
{
a /= 10;
index++;
}
return index;
}

int Sum(int a, int len)
{
int sum = 0;
for (int i = 1; i <= len; i++)
{
sum += a % 10;
a /= 10;
}
return sum;
}


//Напишите программу, которая задаёт принимет на вход длинну массива, и далее элементы массива. Программа должна вывести массив
// Console.Write("введите число: ");
// int len = Convert.ToInt32(Console.ReadLine());
//  Console.Write(len);
//  int []array=new Random().Next(0,len);
// Console.Write("["+string.Join(', ', array)+"]");