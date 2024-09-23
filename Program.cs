const int x = 3, y = 5;
int max;
int[,] arr = new int[x, y] {
                { 10, 50, 13, 80, 40 },
                { 1, 250, 65, 28, 15 },
                { 12, 17, 45, 20, 6 }
            };
max = arr[0, 0];
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        //Assign current array element to max, if (arr[i,j] > max)
        if (arr[i, j] > max)
        {
            max = arr[i, j];
        }

    }
}
//Print Array Elements
Console.Write("Array Elements\n");
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {
        Console.Write(arr[i, j] + ", ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Maximum element:" + max);
Console.ReadLine();