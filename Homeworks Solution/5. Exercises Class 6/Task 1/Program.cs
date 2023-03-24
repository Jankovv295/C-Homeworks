////Task 1: Create a method called NumberStats that accepts a number. This method should:
////Find out if the number is negative or positive, odd or even and decimal or integer
////The number should be entered in the console by the user. Bonus: Ask the user to press Y to try again or X to exit

void NumberStats(double number)
{
    if (number < 0)
    {
        Console.WriteLine("negative");
    }
    else Console.WriteLine("positive");

    if (number % 2 == 0)
    {
        Console.WriteLine("even");
    }
    else Console.WriteLine("odd");

    if (number % 1 == 0)
    {
        Console.WriteLine("integer");
    }
    else Console.WriteLine("double");
}

Console.WriteLine("Enter a number to find the stats: ");
double inputNum = Convert.ToDouble(Console.ReadLine());
NumberStats(inputNum);

while (true)
{
    Console.WriteLine(@"If you want to try again press ""Y"", if you want to exit press ""X"" ");
    char inputForTryAgain = Convert.ToChar(Console.ReadLine());

    if (inputForTryAgain == 'Y')
    {
        Console.WriteLine("Enter a number to find the stats: ");
        double inputNum2 = Convert.ToDouble(Console.ReadLine());
        NumberStats(inputNum2);
    }
    else if (inputForTryAgain == 'X')
    {
        break;
    }
}
