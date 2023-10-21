
// comment

/* comment 
comment*/


// Console.Wirte("Введите число: ");
// int n =Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n*n);


// Console.Write("Vvedite chislo: ");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.Write("Vvedite chislo: ");
// int b=Convert.ToInt32(Console.ReadLine());
// if(b*b==a){
    // Console.WriteLine("yes");
// }
// else
    // Console.WriteLine("No");
Console.Write("Введите номер дня: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
    Console.WriteLine("Понедельник");
else
if (a == 2)
    Console.WriteLine("Вторник");
else
if (a == 3)
Console.WriteLine("Среда");
    else
if (a == 4)
    Console.WriteLine("Четверг");
    else
if (a == 5)
    Console.WriteLine("Пятница");
    else
if (a == 6)
    Console.WriteLine("Суббота");
    else
if (a == 7)
    Console.WriteLine("Воскресенье");
else
    Console.WriteLine("Нет такого дня");