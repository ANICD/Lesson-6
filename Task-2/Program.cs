//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах.
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.
string myStr = "Hello World";
string newStr = "";
newStr = myStr.ToLower();
Console.WriteLine(newStr);