Console.Write("Vvedite name polzovatelja: ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Zdravia zelay tovarish Masha");
}
else
{
    Console.Write("Hallo, ");
    Console.WriteLine(username);
}
