// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]




// void InputArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(0, 10); // [0, 199]
// }


// void ReleaseArray(int[] array)
// {
//     int temp = 0;
//     for(int i = 0; i < array.Length / 2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }
// // 4 6 8 7 9
// // 9 6 8 7 4
// // 9 7 8 6 4
// // 9 7 8 6 4
// // 9 6 8 7 4
// // 4 6 8 7 9

// Console.Clear();
// Console.Write("Размер массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");


int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
if(size[0]<size[1]+size[2]&&
    size[1]<size[0]+size[2]&&
    size[2]<size[1]+size[0])
    Console.WriteLine("yes");
else
    Console.WriteLine("no");


//Console.WriteLine($"[{string.Join(", ", size)}]");
// "1 2 3 4 5"
// "1", "2", "3", "4", "5"
// 1, 2, 3, 4, 5
// [1, 2, 3, 4, 5]