// начало
// ввести имя пользователя
// если имя пользователя совпадает с "МАША" то поприветствовать по особенному
// иначе поприветствовать по обычному
// конец
Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}