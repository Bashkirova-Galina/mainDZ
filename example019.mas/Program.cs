// string[,] table=new string[2,5];
// table[1,2]="слово";
// for(int rows=0;rows<2;rows++)
// {
//     for(int columns=0;columns<5;columns++)
//     {
//         Console.WriteLine($"-{table[rows,columns]}-");
//     }
// }
// void PrintArray(int[,] matrix)
// {
//     for(int i=0;i<3;i++)
//     {
//         for (int j=0;j<4;j++)
//         {
//             Console.WriteLine($"{matrix[i,j]}");
//         }
//         Console.WriteLine();
//     }
// }
// void FillArray(int[,] matrix)
// {
//     for(int i=0;i<matrix.GetLength(0);i++)
//     {
//         for (int j=0;j<matrix.GetLength(1);j++)
//         {
//             matrix[i,j]=new Random().Next(1,10);
//         }
//     }
// }
// int[,] matrix=new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);



int [,] pic=new int[,]
{
{0000000000000000000000000000000000},
{0000000000110000000000000000000000},
{0000000001001000000000000000000000},
{0000000001001000000000000000000000},
{0000000010001000000000000000000000},
{0000000110010000000000000000000000},
{0000001100010000000000000000000000},
{0011111000011111111111111111111000},
{0010000000000000000000000000000100},
{0010000000000000000000000000000100},
{0010000000000000000000001111111000},
{0010000000000000000000000000000100},
{0010000000000000000000000000000100},
{0010000000000000000000001111111000},
{0010000000000000000000000000000100},
{0010000000000000000000000000000100},
{0010000000000000000000000111111000},
{0010000000000000000000000000000100},
{0011111111100000000000000000000100},
{0000000000011111100000000000001000},
{0000000000000000011111111111110000},
{0000000000000000000000000000000000},

};




void PrintImage(int[,] image)
{
    for(int i=0;i<image.GetLength(0);i++)
    {
        for (int j=0;j<image.GetLength(1);j++)
        {
            if(image[i,j]==0)
            Console.Write($" ");
            else Console.Write($"+")
        }
        Console.WriteLine();
    }
}
void FillImage(int row,int col)
{
    if(pic[row,col]==0)
    {
        pic[row,col]=1;
        FillImage(row-1,col);
        FillImage(row-1,col);
        FillImage(row,col-1);
        FillImage(row+1,col);
        FillImage(row,col+1);
    }
}
PrintImage(pic);
FillImage(13,13);
PrintImage(pic);


















