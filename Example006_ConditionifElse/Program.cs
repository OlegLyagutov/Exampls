Console.Write("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "олег")
{
    Console.WriteLine("Ура, это же ОЛЕГ!");
}
else
{   
    Console.Write("Привет, ");
    Console.WriteLine(username);
}