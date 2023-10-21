// int len (int a)
// {
//     int i = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         i++;
//     }
//     return i;
// }

// Console.WriteLine(len(Convert.ToInt32(Console.ReadLine())));

// void mul (int n, ref int s)
// {
//     for (int i = 1; i <= n; i++)
//     {
//         s *= i;
//     }
// }

// int res = 1;
// int n = Convert.ToInt32(Console.ReadLine());
// mul(n, ref res);
// Console.WriteLine(res);

int array=new int[8];
for(int i=0;i<array.Length;i++)

    array[i]=new Random().Next(0,2);

Console.Write("["+string.Join(', ', array)+"]");