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
// ----------------------------------------------------------------------------------------
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
// ----------------------------------------------------------------------------------------------------------
// Console.WriteLine("Write a number:");
// for (int i = 0; i < 5;)
// {
//     String num = Console.ReadLine();
//     int number = 0;
//     bool success = int.TryParse(num, out number);
//     if (success == false)
//     {
//         Console.WriteLine("plz write a number");
//     }
//     else
//     {
//         if (number > 5)
//         {
//             Console.WriteLine("your number is higher than 5.");
//             i++;
//         }
//         else if(number == 5)
//         {
//             Console.WriteLine("your number is 5.");
//             i++;
//         }
//         else
//         {
//             Console.WriteLine("your number is lower than 5.");
//             i++;
//         }
//     }
// }
// Console.WriteLine("you have written five number, goodbye.");
// Console.ReadLine();
// ---------------------------------------------------
// Console.WriteLine("write something:");
// int i = 0;

// while (i == 0)
// {
//     string something = Console.ReadLine();

//     bool num = something.All(char.IsDigit);
//     if (num == true)
//     {
//         Console.WriteLine("goodbye.");
//         Console.ReadKey();
//         i++;
//     }
//     else
//     {
//         Console.WriteLine("try again:");
//     }
// }
// --------------------------------------------------------------------------------------

Console.WriteLine("welcome to guess ze number!");
Console.WriteLine("the number is bewtween 0 and 9.");
int number = 20;
int num = 0;
while (num != number)
{
    number = Random.Shared.Next(9);
    Console.WriteLine("plz write your guess:");
    string guess = Console.ReadLine();
    bool success = int.TryParse(guess,out num);
    if (success == false)
    {
        Console.WriteLine("please write a number.");
    }
    else if (success == true)
    {
        if (num > 9 || num < 0)
        {
            Console.WriteLine("please write a number between 0 and 9");
        }
        else if (num != number)
        {
            Console.WriteLine($"youbguessed wrong. the anser is {number}.");
        }
        else if (num == number)
        {
            Console.WriteLine("congrats! you guessed right");
            Console.WriteLine("press enter to exit.");
        }
    }
}
Console.ReadKey();