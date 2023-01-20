
//int sum = 0;
//int[,] arr = new int[3, 3]
//{
//    { 4, 5, 9},
//    { 6, 8, 3},
//    { 7, 5, 7}
//};
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum += arr[i, j];
//        }

//    }
//}
//Console.WriteLine(sum);












//int[,] arr = new int[2, 2]
//{
//    {5, 9 },
//    {5, 10},
//};
//int[,] arr2 = new int[2, 2]
//{
//    {7, 6 },
//    {6, 2},
//};
//int[,] arr3 = new int[2, 2]
//{
//    {0, 0 },
//    {0, 0 },
//};

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr3[i, j] = arr [i, j] + arr2 [i,j];
//        Console.Write(arr3[i,j] + " ");
//    }
//    Console.WriteLine();
//}






int[,] arr = new int[5,5]
{
    { 5,6, 4, 5, 4},
    { 4, 8, 2, 3, 4},
    { 5, 6, 7, 3, 4},
    { 3, 7, 8, 7, 9},
    { 9, 1, 7, 5, 6},
};
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if(i > 3 - j)
        {
            arr[i, j] = 0;
        }
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}