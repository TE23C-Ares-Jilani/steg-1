// if (6 > 3 || 6 == 3)
// {
//     Console.WriteLine("Helol world!");
// }
// Console.ReadLine();
// --------------------------------------------------------------------------------------
// Console.WriteLine("Write username plz:");
// string användarnamn = Console.ReadLine();
// Console.WriteLine("Write password plz:");
// string password = Console.ReadLine();
// if (användarnamn == "kalleanka" && password == "12345")
// {
//     Console.WriteLine("Welcome!");
//     Console.ReadLine();
// }
// else
// {
//     Console.Clear();
//     Console.WriteLine("username or password wrong.");
//     Console.ReadLine();
// }
// --------------------------------------------------------------------------------------
// for (int i = 0; i < 32; i++)
// {
//     Console.WriteLine("Helol, World!");
// }
// Console.ReadKey();
// string password = "12345";
// string guess = "";
// Console.WriteLine("Guess the 5 character password:");

// while (guess != password)
// {
//     guess = Console.ReadLine();
    
//     if (guess != password)
//     {
//         Console.WriteLine("Wrong, guess again:");
//     }
// }
// Console.WriteLine("Correct!");
// Console.WriteLine("goodbye.");
// Console.ReadKey();
Console.WriteLine("Write a number:");
for (int i = 0; i < 5;)
{
    String num = Console.ReadLine();
    int number = 0;
    bool success = int.TryParse(num, out number);
    
    if (success == false)
    {
        Console.WriteLine("plz write a number");
    }
    else
    {
        if (number > 5)
        {
            Console.WriteLine("your number is higher than 5.");
            number++;
        }
        else
        {

        }
    }
}