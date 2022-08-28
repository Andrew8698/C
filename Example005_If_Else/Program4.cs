Console.Write("Введите имя пользовтеля: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Оу, это Маша..");
}
else
{
    Console.Write("Здарова, ");
    Console.WriteLine(username);

}