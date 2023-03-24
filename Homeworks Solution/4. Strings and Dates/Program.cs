//// Task 1: Take one string from the input and print its last 5 characters.

Console.WriteLine("Enter a sentence: ");
string userInput = Console.ReadLine();
Console.WriteLine(userInput.Substring(userInput.Length - 5));


////Task 2: Take a sentence as input and print its words.

Console.WriteLine("Enter a sentence: ");
string userInput2 = Console.ReadLine();
char[] chars = userInput2.ToCharArray();
foreach (var item in chars)
{
    Console.WriteLine(item);
}


//Task 3: Create a function that takes a number as input. 
//This method should return the sum of the digits in the number.

int SumOfDigitsInANum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int result = SumOfDigitsInANum(425);
Console.WriteLine(result);



//Task 4: Make a method called AgeCalculator. The method will have one input parameter, your birthday date
//The method should return your age. Show the age of a user after he inputs a date
//Note: take into consideration if the birthday is today, after or before today

int AgeCalculator(DateTime birthDate)
{
    int age = 0;
    DateTime currentDateTime = DateTime.Today;

    if (birthDate.Month <= currentDateTime.Month && birthDate.Day <= currentDateTime.Day)
    {
        age = currentDateTime.Year - birthDate.Year;
    }
    else if (birthDate.Month >= currentDateTime.Month && currentDateTime.Day >= currentDateTime.Day)
    {
        age = currentDateTime.Year - birthDate.Year - 1;
    }

    return age;
}

Console.WriteLine(AgeCalculator(DateTime.Parse("15/02/2000")));
