// See https://aka.ms/new-console-template for more information
//TASK 1
//Create 4 methods called Sum, Subtract, Multiply and Divde. The method will accept two numbers as parameter
//and return a result from the operation of the two numbers. Ask a person from the console to enter operators
//Then ask the person to enter two numbers. Use switch ** Additional: Check divide by zero **

int Sum (int num1, int num2)
{
    return num1 + num2;
}

int Subtract (int num1, int num2)
{
    return num1 - num2;
}

int Multiply (int num1, int num2)
{
    return (num1 * num2);
}

int Divide (int num1, int num2)
{
    //int sum = num1 / num2;
    //if (num2 == 0)
    //{
    //    Console.WriteLine("ERROR");
    //}
    return num1 / num2;
}

string Calculator (char operation, int num1, int num2)
{

    int result = 0;
    string consoleResult = null;

    switch (operation)
    {
        case '+':
           result = Sum(num1, num2);
            consoleResult = $"The result of summing the two numbers you entered is: {result}";
            break;
        case '-':
            result = Subtract(num1, num2);
            if (num2 == 0) consoleResult = "ERROR: You can't divide with 0";
            consoleResult = $"The result of subtracting the two numbers you entered is: {result}";
            break;
        case '*':
            result = Multiply(num1, num2);
            consoleResult = $"The result of multiplying the two numbers you entered is: {result}";
            break;
        case '/':
            result = Divide(num1, num2);
            consoleResult = $"The result of dividing the two numbers you entered is: {result}";
            break;
        default:
            consoleResult = "Invalid operator input";
            break;
    }
    return consoleResult;
}

Console.WriteLine("Enter the operation you want to be executed +, -, *, /");
char inputOperation = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Enter two numbers");
int inputNum1 = Convert.ToInt32(Console.ReadLine());
int inputNum2 = Convert.ToInt32(Console.ReadLine());

string variableForCalculator = Calculator(inputOperation, inputNum1, inputNum2);
Console.WriteLine(variableForCalculator);



