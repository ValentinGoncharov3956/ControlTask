//Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.

void ArrayCheck(string[] array, string[] array2)
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");   
    }
    Console.WriteLine($"]");;
}

string[] ArrayString = new string[5] {"string", "array", "925", "24", "12"};
string[] ArrayString2 = new string[ArrayString.Length];

ArrayCheck(ArrayString, ArrayString2);
PrintArray(ArrayString);
Console.WriteLine();
PrintArray(ArrayString2);
