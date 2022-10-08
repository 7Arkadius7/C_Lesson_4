// Console.Clear();

// string[,] table = new string[2, 5];

// // String.Empty - константа

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"{table[rows, columns]}-");
//     }
// }
//____________________________________________________________________________________________



void PrintArray(int[,] matr) // создаем метод
{
    for (int i = 0; i < matr.GetLength(0); i++) // где matrix - название матрицы, а .GetLength(0) - количество строк в данной матрице (0)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // где где matrix - название матрицы, а .GetLength(1) - количество строк в данной матрице (1)
        {
            System.Console.Write($"{matr[i, j]} "); // выводим данные из определенного столбца (i) и строки (j).
                                                    // i берется из первого цикла, j из подцикла
        }
        System.Console.WriteLine(); // переход на новую строку
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) // где matrix - название матрицы, а .GetLength(0) - количество строк в данной матрице (0)
    {
        for (int j = 0; j < matr.GetLength(1); j++) // где где matrix - название матрицы, а .GetLength(1) - количество строк в данной матрице (1)
        {
            matr[i, j] = new Random().Next(1, 10); // дабавляем случайное число в определенный столбец (i) и строку (j).
                                                   // i берется из первого цикла, j из подцикла. Берется i и прогоняется по всем значениям j
                                                   // затем берется i+1 и прогоняются все значения j
                    }
    }
}

int[,] matrix = new int[3, 4]; // вводим матрицу данных
PrintArray(matrix); // выводим матрицу с 0
System.Console.WriteLine(); // переход на новую строку
FillArray(matrix); // используем метод FillArray по заполнению матрицы случайными числами
PrintArray(matrix); // выводим матрицу с случайными числами
                    //______________________________________________________________________________________________