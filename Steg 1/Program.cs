// if (6 > 3 || 6 == 3)
// {
//     Console.WriteLine("Helol world!");
// }
// Console.ReadLine();

Console.WriteLine("Write username plz:");
string användarnamn = Console.ReadLine();
Console.WriteLine("Write password plz:");
string password = Console.ReadLine();
if (användarnamn == "kalleanka" && password == "12345")
{
    Console.WriteLine("Welcome!");
    Console.ReadLine();
}
else
{
    Console.Clear();
    Console.WriteLine("username or password wrong.");
    Console.ReadLine();
}
