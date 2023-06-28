

//Задача 19:

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - не является палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"{number} - не является пятизначным числом");
// }


//Задача 21:

// int A1 = ReadInt("Введите координату A первой точки: ");
// int B1 = ReadInt("Введите координату B первой точки: ");
// int C1 = ReadInt("Введите координату C первой точки: ");
// int A2 = ReadInt("Введите координату A второй точки: ");
// int B2 = ReadInt("Введите координату B второй точки: ");
// int C2 = ReadInt("Введите координату C второй точки: ");

// int q = A2 - A1;
// int w = B2 - B1;
// int e = C1 - C2;

// double length = Math.Sqrt(q * q + w * w + e * e);
// Console.WriteLine($"Длинна отрезка {length}");

// int ReadInt(string message)
// {
//  Console.Write(message);
//  return Convert.ToInt32(Console.ReadLine());
// }




//Задача 23:

// int number = ReadInt("Введите число N: ");

// for (int i = 1; i <= number; i++)
// { 
//     Console.Write($"{i*i*i} ");
// }



// // Функция ввода сообщения
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }