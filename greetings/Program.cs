//Знакомимся с ветвлением if - else
Console.WriteLine("Enter username");
string username = Console.ReadLine();

if (username.ToLower() == "mike")
{
    Console.WriteLine("WHATASUP NIGGA");
}   
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}