//Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами.
//Сформировать строку, в которой слова расположены в обратном порядке. В полученной строке слова должны быть также разделены пробелами.
Console.WriteLine("Напишите фразу: ");
string inputString = Console.ReadLine();
string[] wordsArr = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int len = wordsArr.Length;
//----------------------------------------
for (int i = 0; i < len / 2; i++)
{
    string tempString = wordsArr[i];
    wordsArr[i] = wordsArr[len - 1 - i];
    wordsArr[len - 1 - i] = tempString;
}
for (int i = 0; i < len; i++)
{
    Console.Write(wordsArr[i] + " ");
}
//----------------------------------------
Console.WriteLine();
