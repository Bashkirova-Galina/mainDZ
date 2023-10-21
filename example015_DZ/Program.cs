Console.Clear();
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//Console.WriteLine("Введите трёхзначное число ");
//while(true){
//    string input=Console.ReadLine();
 //   if(!input.Equals("exit"))
//Console.WriteLine("{0}->{1}", input,input[1]);
 //   else break;
//}


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//int ThirdDigit(int number)
//{
//int result=-1;
 //   if (number >=100)
 //   {
//while(number > 999)
 //       {
 //       number = number / 10;
 //       }
  //      int result = number % 10;
 //   }
    

//return result; 
//}
// Console.Write("Input three-digit number: ");
//int number1 = Convert.ToInt32(Console.ReadLine());

//if (ThirdDigit(number1) == -1)
//Console.WriteLine("третьей цифры нет");
//else
//Console.WriteLine($"Third digit is {ThirdDigit(number1)}");


//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели ");
int day=Convert.ToInt32(Console.ReadLine());
if (day==6||day==7)
Console.WriteLine("да");
else
Console.WriteLine("нет");