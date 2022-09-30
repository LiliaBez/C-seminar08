/*Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой 
строки двумерного массива.*/

int height = EnterInt("Введите количество строк: "); //высота массива
int width = EnterInt("Введите количество столбцов: ");  //ширина массива

int[,] numbers = new int[height, width];

Fill2DArray(numbers, height, width);
Print2dArray(numbers, height, width);

FillInDescendingOrder(numbers);
Print2dArray(numbers, height, width);


int EnterInt(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int widht)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 21);
        }
    }
}

void Print2dArray(int[,] numbers, int height, int widht)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FillInDescendingOrder (int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - j; j++)
        {
            if (numbers[i, j + 1] >= numbers[i, j])
            {
                Swap(ref numbers[i, j], ref numbers[i, j + 1]);
            }
        }
        
    }
    Console.WriteLine();
}


static void Swap (ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
