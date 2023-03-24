//Task 2: Create a class User with the following:
//Id - int;  Username - string;  Password - string
//Messages - Array of strings Create an array of users and add 3 users to it manually ( hard-coded ).

//Create a Console UI that will ask the user:
//Log in - When selected the user should be asked for username and password. If the user is found print welcome message and the messages that the user has in the Messages property:
//Welcome NAME. Here are your messages:            Message1;             Message2
//If not found, it should print an error message

//Register - When selected the user should be asked to enter ID, Username and password. It should then check if a there is already a username in the array of users like that. If there is, print a message that there is already a user called like that. If not, create a new user object from the information given in the console and add it to the Users array. Then print all the users by Id and Username
//Registration complete! Users:  23 Username1;  44 Username2;  1 Username3;   56 Username4**

using System;
using Task_2;

User[] arrayOfUsers = { new User(21, "Viktor", "123-123"), new User(24, "Bojan", "lozinka"), new User(29, "Miki", "12345678") };


Console.WriteLine(@"To log in press ""L"", if you don't have an account click ""R"" to register: ");
char inputLoginOrRegister = Convert.ToChar(Console.ReadLine());

void LogIn()
{
    Console.WriteLine("Enter your Username:");
    string inputUsername = Console.ReadLine();
    Console.WriteLine("Enter your Password:");
    string inputPassword = Console.ReadLine();

    bool userFound = false;
    foreach (var item in arrayOfUsers)
    {
        if (inputUsername == item.Username && inputPassword == item.Password)
        {
            item.Messages();
            userFound = true;
            break;
        }
    }
    if (!userFound)
    {
        Console.WriteLine("Error: The username or password you entered isn't connected to an account.");
    };
}


void Register()
{
    Console.WriteLine("Welcome to our Console App. To Register enter the following information:");
    Console.WriteLine("Enter Id: ");
    int inputRegisterId = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Username: ");
    string inputRegisterUsername = Console.ReadLine();
    Console.WriteLine("Enter Password: ");
    string inputRegisterPassword = Console.ReadLine();

    bool idFound = false;
    bool usernameFound = false;
    bool validPassword = inputRegisterPassword.Length > 5;

    foreach (var item in arrayOfUsers)
    {
        if (inputRegisterId == item.Id)
        {
            Console.WriteLine("There is already a user with the same Id. Try with other Id");
            idFound = true;
            break;
        }

        if (inputRegisterUsername == item.Username)
        {
            Console.WriteLine("There is already a user called like that. Try with other username");
            usernameFound = true;
            break;
        }
    }

    if (!idFound && !usernameFound && validPassword)
    {
        User inputUser = new User(inputRegisterId, inputRegisterUsername, inputRegisterPassword);
        Array.Resize(ref arrayOfUsers, arrayOfUsers.Length + 1);
        arrayOfUsers[arrayOfUsers.Length - 1] = inputUser;
        foreach (var element in arrayOfUsers)
        {
            Console.WriteLine(element.UserInfo());
        };

        Console.WriteLine(@"If you want to Log in now press ""Y"", and if you want to exit press ""X"" ");
        char inputContinueOrExit = Convert.ToChar(Console.ReadLine());

        if (inputContinueOrExit == 'Y')
        {
            LogIn();
        }
    }
    else
    {
        if (!validPassword)
        {
            Console.WriteLine("The password must contain at least 5 characters");
        }
    }
}

if (inputLoginOrRegister == 'L')
{
    LogIn();
} else if (inputLoginOrRegister == 'R')
{
    Register();
}
