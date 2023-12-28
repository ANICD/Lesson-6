//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine("Напишите фразу: ");
string inputString = Console.ReadLine();
string newString = inputString.Replace("!", "").Replace(",", "").Replace(" ", "").ToLower().Trim();
int len = newString.Length;
bool flag = false;
for (int i = 0; i < len / 2; i++)
{
    if (newString[i] != newString[len - 1 - i])
    {
        Console.WriteLine("Фраза не полиндром! Выход из программы.");
        flag = false;
        break;
    }
    else
        flag = true;
}
if (flag)
    Console.WriteLine("Фраза: " + "\"" + inputString + "\"" + " - полиндром!");