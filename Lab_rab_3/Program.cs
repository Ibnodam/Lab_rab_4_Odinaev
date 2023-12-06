// Лабораторная работа 4. Задание 1.

//Console.Write("Введите количество элементов массива: ");
//int n = int.Parse(Console.ReadLine());
//string[] mas = new string[n];


//for (int i = 0; i < n; i++)
//{
//    Console.Write($"Введите элемент массива с номером {i}: ");
//    mas[i] = Console.ReadLine();
    
//}


//for (int i = 0; i < n; i++)
//{
   

//    for (int j = i + 1; j < n; j++)
//    {
//        if (mas[i] == mas[j])
//        {
//            Console.WriteLine($"Одинаковвые элементы массива на позициях с номерами {i} {j}: '{mas[i]}' и '{mas[j]}' соответственно.");

//        }

//    }

//}




///////////////////////// Задание 2
//////double max = 0;
//////double[,] A = new double[5,10];
//////Random random = new Random();
//////Console.WriteLine("Исходная матрица A:");
//////for (int i = 0; i < A.GetLength(0); i++)
//////{
//////    for (int j = 0; j < A.GetLength(1); j++)
//////    {
//////        A[i, j] = random.Next(-256, 256);
//////        Console.Write(A[i, j] + "  " + "| ");
//////        if (Math.Abs(A[i, j]) > max) max = A[i, j];
//////    }
//////    Console.WriteLine();
//////}
//////double[,] B = new double[5,10];
//////Console.WriteLine($"Конечная матрица (число с максимальным модулем = {max}): ");
//////for (int i = 0; i < B.GetLength(0); i++)
//////{
//////    for (int j = 0; j < B.GetLength(1); j++)
//////    {
//////        B[i, j] = A[i, j] / max;
//////        Console.Write(Math.Round(B[i, j],2) + "  " + "| ");
//////    }
//////    Console.WriteLine();
//////}


