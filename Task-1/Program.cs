//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

char[,] charArr = new char[,] {

            { 'H', 'E', 'L', 'L', 'O' },
            { 'W', 'O', 'R', 'L', 'D' }
        };

string str = "";

for (int i = 0; i < charArr.GetLength(0); i++)
{
    for (int j = 0; j < charArr.GetLength(1); j++)
    {
        str += charArr[i, j];
    }
}
Console.WriteLine(str);
