// // void InputArray(int[] array)
// // {
// //     for(int i=0;i<array.Length;i++)
// //         array[i]=new Random().Next(-9,10);
    
// // }
// // void ReleseArray(int[] array)
// // {
// //     int SumPos=0;
// //     int sumNeg=0;
// //         for(int i = 0; i < array.Length; i++)
// //             array[i] *= -1;
// // }




// // Console.Clear();
// // Console.Write("Размер массива");
// // int n=Convert.ToInt32(Console.Readline());
// // int[] array=new int(n);
// // InputArray(array);
// // Console.WrteLine($"({string.join(", ", array)})");
// // ReleseArray(array);



// // void InputArray(int[] array)
// // {
// //     for(int i=0;i<array.Length;i++)
// //         array[i]=new Random().Next(0,100);
    
// // }
// // int ReleseArray(int[] array)
// // {
    
// //     int count = 0;
// //     for(int i = 0; i < array.Length; i++)
// //             if ((array[i] >= 10)&&(array[i] <= 99))
// //                 count++;
// //     return count;

// // }
// // Console.Clear();
// // Console.Write("Размер массива");
// // int n=Convert.ToInt32(Console.ReadLine());
// // int[] array=new int(n);
// // InputArray(array);
// // Console.WriteLine($"[{string.join(", ", array)}]");
// // ReleseArray(array);



// // public class Answer
// // {
// //     public static int CountEvenElements(int[] array)
// //     { 
// //     // Введите свое решение ниже
// //       int count=0;
// //       for(int i=0; i<array.Length; i++)
// //         {
// //           if (array[i]%2==0)
// //             count++;
// //            return count;
// //         }
         
// //       }

// //     public static void PrintArray(int[] array)
// //     {
// //     // Введите свое решение ниже
// //     for(int i=0;i<array.Length;i++)
// //     {
// //       Console.Write(array[i]);}
    
    

// //       }


// // // Не удаляйте и не меняйте метод Main! 
// //     public static void Main(string[] args)
// //     {
// //         int[] array;
// //         if (args.Length == 0)
// //         {
// //            // Здесь вы можете поменять значения для отправки кода на Выполнение
// //             array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
// //         }
// //         else
// //         {
// //             string[] argStrings = args[0].Split(", ");
// //             array = new int[argStrings.Length];
// //             for (int i = 0; i < argStrings.Length; i++)
// //             {
// //                 if (int.TryParse(argStrings[i], out int number))
// //                 {
// //                     array[i] = number;
// //                 }
// //                 else
// //                 {
// //                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
// //                     return;
// //                 }
// //             }
// //         }

// //         // Не удаляйте строки ниже
// //         Console.WriteLine("Массив:");
// //         PrintArray(array);
// //         int evenCount = CountEvenElements(array);
// //         Console.WriteLine($"Количество четных элементов: {evenCount}");
// //     }
// // }


// using System;

// public class Answer
// {
//     public static int SumOddElements(int[] array)
//     {
// // Введите свое решение ниже
//     int count=0;
//      foreach (int number in array)
//         {
//             if (number % 2 != 0)
//             {
//                 count+=number;
//             }
//         }
//         return count;
//     } 



//     public static void PrintArray(int[] array)
//     {
//          // Введите свое решение ниже
//     foreach (int number in array)
//         {
//             Console.Write($"{number}\t");
//         }
//         Console.WriteLine();

//     }


// // Не удаляйте и не меняйте метод Main! 
//     public static void Main(string[] args)
//     {
//         int[] array;
//         if (args.Length == 0)
//         {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
//         }
//         else
//         {
//             string[] argStrings = args[0].Split(", ");
//             array = new int[argStrings.Length];
//             for (int i = 0; i < argStrings.Length; i++)
//             {
//                 if (int.TryParse(argStrings[i], out int number))
//                 {
//                     array[i] = number;
//                 }
//                 else
//                 {
//                     Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
//                     return;
//                 }
//             }
//         }

//         // Не удаляйте строки ниже
//         PrintArray(array);
//         int sumOdd = SumOddElements(array);
//         Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
//     }
// }