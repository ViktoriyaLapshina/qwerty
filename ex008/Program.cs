Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "чипилюк")
{
    Console.WriteLine("Ура, это же Чипилюк!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}