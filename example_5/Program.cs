Console.Write("Enter your name >> ");
string username = Console.ReadLine();

if(username.ToLower() == "masha")
{
        Console.WriteLine("It's Masha! Finally!");
}
else
{
        Console.Write("Hello, ");
        Console.Write(username);
}