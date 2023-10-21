// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i,j] = i + j;
// }

// void ReleseMatrix(int[,] matrix)
// {

//       int n1=n1/10;
//       int n2=n1%10;
//       if (n1>matrix.GetLength(0)||n2>matrix.GetLength(1))
//       else
//     Console.WriteLine(matrix);

// }


// void PrintMatrix (int[,] matrix)
// {
//     for (int i=0; i<matrix.GetLength(0); i++)
//     {
//         for (int j=0; j<matrix.GetLength(1); j++)
//         {
//           Console.Write($"{matrix[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }





// Console.Clear();
// Console.Write("Введите размер матрицы ");
// int[] size=Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
// int[,] matrix=new int[size[0],size[1]];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// Console.WriteLine();
// ReleseMatrix(matrix);


// int summa(int a, int b)
// {
//     if(b==0)
//         return a;
//     return summa(a+1,b-1);
// }


// Console.Write("Введите элемент ");
// int a=Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите элемент");
// int b=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(summa(a,b));




// string rec(int n)
// {
//     if (n==0)
//         return "";
//     return rec(n-1)+$"{n}";
// }

// Console.Write("Введите элемент ");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));





// 



// int rec(int n)
// {
//    if (n<10)
//         return 4;
//     return rec(n/10)+n%10;
   
// }

// Console.Write("Введите элемент ");
// int n=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(n));






//  int rec(int a,int b)
// {
//     if (b==0)
//         return 1;
//    return rec(a,b-1)*a;
   
// }

// Console.Write("Введите элемент ");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите элемент ");
// int b=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(rec(a,b));

