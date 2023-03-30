//Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.


string[] ArrayString = new string[5] {"string", "array", "925", "24", "12"};
string[] ArrayString2 = new string[ArrayString.Length];
int count = 0;

for (int i = 0; i < ArrayString.Length; i++)
{
    if (ArrayString[i].Length <= 3)
    {
        ArrayString2[count] = ArrayString[i];
        count++;
    }
}


