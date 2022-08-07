//ДВУМЕРНЫЕ МАССИВЫ

// индексы стобцов и строк меняются от нуля
string[,] table = new string[2, 5];
//для строк инициализация string.Empty
//table[0,0]   table [0,1] table [0,2] table [0,4]
//table[1,0]   table [1,1] table [1,2] table [1,4]

//table[1, 2] = "slovo";
//for (int rows = 0; rows < 2; rows++)
//{
//    for (int columns = 0; columns < 5; columns++)
//    {
//        Console.WriteLine($"-{table[rows,columns]}-");
        //интерполляция, обращение к элементам массива через имя-table,индекс строки rows,столбца-columns
//    }
//}

//Матрица или  прям таблица чисел(3 строки,4 столбца)
//описываем метод, который отдельно будет печатать матрицу на экран и заполнять числами
void PrintArray(int[,] matr)//в качестве аргумента передаем прям.таблицу чисел(2мерная табл.чисел)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    //можно заменить i < 3 на matrix.GetLength(0)//0-кол-во строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)
    //можно заменить j < 4 на matrix.GetLength(1)//1-кол-во столбцов в массиве
        {
            Console.Write($"{matr[i,j]} ");
        }
    Console.WriteLine();
    }
}
//Описываем доп.метод,который заполняет матрицу случайными числами
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
       for (int j = 0; j < matr.GetLength(1); j++)
       {
            matr[i, j] = new Random().Next(1, 10);//[1; 10)
       } 
    }
}

int [,] matrix = new int[3,4];//3 строки,4 столбца
//при инициализации массива должны определять сколько памяти нужно будет
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);