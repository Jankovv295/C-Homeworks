// See https://aka.ms/new-console-template for more information

// TASK 1
//Create new console application “RealCalculator” that takes two numbers from the input and asks 
//what operation would the user want to be done ( +, - , * , / ). Then it returns the result.



Console.WriteLine("Enter two numbers");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter what operation would you like to be done ( +, - , * , / ) ");
string inputOperator = Console.ReadLine();


int result;

if (inputOperator == "+")
{
    result = num1 + num2;
    Console.WriteLine("The result is " + result);
}
else if (inputOperator == "-")
{
    result = num1 - num2;
    Console.WriteLine("The result is " + result);

}
else if (inputOperator == "*")
{
    result = num1 * num2;
    Console.WriteLine("The result is " + result);

}
else if (inputOperator == "/")
{
    result = (num1 / num2);
    Console.WriteLine("The result is " + result);
}





// TASK 2
//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.

Console.WriteLine("Enter 4 numbers to calculate the average");

int inp1 = Convert.ToInt32(Console.ReadLine());
int inp2 = Convert.ToInt32(Console.ReadLine());
int inp3 = Convert.ToInt32(Console.ReadLine());
int inp4 = Convert.ToInt32(Console.ReadLine());

float avgResult = (inp1 + inp2 + inp3 + inp4) / 4f;

Console.WriteLine("The average number of " + inp1 + ", " + inp2 + ", " + inp3 + " and " + inp4 + " is: " + avgResult);