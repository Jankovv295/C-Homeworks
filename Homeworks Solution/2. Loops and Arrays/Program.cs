// See https://aka.ms/new-console-template for more information

//TASK 1:
//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables
//so that the first variable has the second value and the second variable the first value.

Console.WriteLine("Enter two numbers");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int temp;

temp = number1;
number1 = number2;
number2 = temp;

Console.WriteLine($"After swapping number1 has value {number1} and number2 has value {number2}");





//TASK 2:
//Make a console application called SumOfEven. Inside it create an array of 6 integers. 
//Get numbers from the input, find and print the sum of the even numbers from the array:


int[] arr = new int[6];
int sum = 0;

Console.WriteLine("Enter 6 numbers");
for (int i = 0; i < 6; i++)
{
    int arrInput = Convert.ToInt32(Console.ReadLine());
    arr[i] = arrInput;

    if (arr[i] % 2 == 0)
    {
        sum += arr[i];
    }
}
Console.WriteLine($"The sum of the numbers you entered that are divided by 2 is {sum}");





//TASK 3:
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names (strings).
//Get a number from the console between 1 and 2 and print the students from that group in the console.

string[] studentsg1 = { "marko", "marija", "martin", "biljana", "kristijan" };
string[] studentsg2 = { "viktor", "nenad", "nikola", "monika", "boban" };

Console.WriteLine("enter student group: ( there are 1 and 2 )");
string response = Console.ReadLine(); //namerno e string da isprobam:)


if (response == "1")
{
    foreach (var item in studentsg1)
    {
        Console.WriteLine(item);

    }
}
else if (response == "2")
{
    foreach (var item in studentsg2)
    {
        Console.WriteLine(item);

    }
}


//istoto so int

//int response = Convert.ToInt32(Console.ReadLine());

//if (response == 1)
//{
//    foreach (var item in studentsG1)
//    {
//        Console.WriteLine(item);

//    }
//}
//else if (response == 2)
//{
//    foreach (var item in studentsG2)
//    {
//        Console.WriteLine(item);

//    }
//}








