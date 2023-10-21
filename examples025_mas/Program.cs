// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i,j] = i + j;
// }

// void ReleseMatrix(int[,] matrix)
// {
// int temp=0;
    
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[0,j];
//             matrix[0,j]=matrix[matrix.GetLength(0)-1,j];
//             matrix[matrix.GetLength(0)-1,j]=temp;

      
//         }
//     Console.WriteLine();

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
// ReleseMatrix(matrix);
// PrintMatrix(matrix);





// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             matrix[i,j] = i + j;
// }

// void ReleseMatrix(int[,] matrix)
// {
// int min = matrix[0,0];
//     int [] a = {0,0};
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             if (matrix[i,j] < min)
//             {
//                 min = matrix[i,j];
//                 a[0] = i;
//                 a[1] = j;
//             }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//             if ((i!=a[0])&&(j!=a[1]))
//                 Console.Write($"{matrix[i,j]}\t");
//     Console.WriteLine();  
//     }  
        

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
// ReleseMatrix(matrix);













void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i,j] = i + j;
}

void ReleseMatrix(int[,] matrix)
{
int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = i+1; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i,j];
            matrix[i,j] = matrix[j,i];
            matrix[j,i] = temp;
        }

}


void PrintMatrix (int[,] matrix)
{
    
    for (int i=0; i<matrix.GetLength(0); i++)
    {
        for (int j=0; j<matrix.GetLength(1); j++)
        {
          Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}





Console.Clear();
Console.Write("Введите размер матрицы ");
int[] size=Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
while(size[0]!=size[1])
{
    Console.Write("Ошибка введите размер матрицы");
    size=Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
}



int[,] matrix=new int[size[0],size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleseMatrix(matrix);
PrintMatrix(matrix);
