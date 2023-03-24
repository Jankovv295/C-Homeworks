


//using Task_3;

//ATM[] arrOfAtmUsers = 
//{ 
//    new ATM("Viktor", "Jankov", "5160-2340-8875-1234", 1234, 1000), 
//    new ATM("Bob", "Bobovski", "4213-4563-8765-2341", 5678, 2350), 
//    new ATM("Jim", "Jimovski", "7653-1254-8432-6224", 2121, 3000) 
//};


//Console.WriteLine("Welcome to the ATM app");
//Console.WriteLine("Please enter your card number:");
//string inputCardNumber = Console.ReadLine();

//Console.WriteLine("Enter Pin: ");
//int inputPin = Convert.ToInt32(Console.ReadLine());
//bool isUserAuthenticated = false;


//foreach (var item in arrOfAtmUsers)
//{
//    if (inputCardNumber == item.CardNumber && inputPin == item.getPin())
//    {
//        isUserAuthenticated = true;
//        ChooseActionMethod();
//        OtherAction();
//        break;
//    }
//}
//if(!isUserAuthenticated)
//    {
//        Console.WriteLine("No such a user with card number was found or wrong pin");
//    };


//void OtherAction(ATM user)
//{
//    Console.WriteLine(@"Do you want to do another action? Type ""yes"" to continue or ""no"" to exit");
//    string takeOtherActionOrNot = Console.ReadLine();

//    switch (takeOtherActionOrNot)
//    {
//        case "yes":
//            ChooseActionMethod();
//            OtherAction();
//            break;
//        case "no":
//            Console.WriteLine($"Goodbye{item.Name}");
//            break;
//    }
//}

//void ChooseActionMethod()
//{
//    Console.WriteLine("Press 1-3 for what would you like to do next:");
//    Console.WriteLine("\r 1.Check Balance  \r\n 2.Cash Withdrawal \r\n 3.Cash Deposit");
//    int inputChooseAction = Convert.ToInt32(Console.ReadLine());

//    switch (inputChooseAction)
//    {
//        case 1:
//            Console.WriteLine(item.CheckBalance());
//            break;
//        case 2:
//            Console.WriteLine("Enter the ammount of dollars you would like to Withdraw:");
//            int inputWithdrawAmmount = Convert.ToInt32(Console.ReadLine());
//            item.CashWithdrawal(inputWithdrawAmmount);
//            break;
//        case 3:
//            Console.WriteLine("Enter the ammount of dollars you would like to Deposit:");
//            int inputDepositAmmount = Convert.ToInt32(Console.ReadLine());
//            item.CashDeposit(inputDepositAmmount);
//            break;
//        default:
//            Console.WriteLine("Error you have entered invalid number.");
//            break;
//    }
//}



using Task_3;

ATM[] arrOfAtmUsers =
{
    new ATM("Viktor", "Jankov", "5160-2340-8875-1234", 1234, 1000),
    new ATM("Bob", "Bobovski", "4213-4563-8765-2341", 5678, 2350),
    new ATM("Jim", "Jimovski", "7653-1254-8432-6224", 2121, 3000)
};

Console.WriteLine("Welcome to the ATM app");
Console.WriteLine("Please enter your card number:");
string inputCardNumber = Console.ReadLine();

Console.WriteLine("Enter Pin: ");
int inputPin = Convert.ToInt32(Console.ReadLine());
bool isUserAuthenticated = false;
ATM authenticatedUser = null;

foreach (var item in arrOfAtmUsers)
{
    if (inputCardNumber == item.CardNumber && inputPin == item.getPin())
    {
        isUserAuthenticated = true;
        authenticatedUser = item;
        break;
    }
}

if (isUserAuthenticated)
{
    Console.WriteLine($"Welcome {authenticatedUser.FirstName} {authenticatedUser.LastName}");

    ChooseActionMethod(authenticatedUser);

    OtherAction(authenticatedUser);

}
else
{
    Console.WriteLine("No such a user with card number was found or wrong pin");
}


void OtherAction(ATM user)
{
    Console.WriteLine(@"Do you want to do another action? Type ""yes"" to continue or ""no"" to exit");
    string takeOtherActionOrNot = Console.ReadLine();

    switch (takeOtherActionOrNot)
    {
        case "yes":
            ChooseActionMethod(user);
            OtherAction(user);
            break;
        case "no":
            Console.WriteLine($"Goodbye {user.FirstName}");
            break;
    }
}

void ChooseActionMethod(ATM user)
{
    Console.WriteLine("Press 1-3 for what would you like to do next:");
    Console.WriteLine("\r 1.Check Balance  \r\n 2.Cash Withdrawal \r\n 3.Cash Deposit");
    int inputChooseAction = Convert.ToInt32(Console.ReadLine());

    switch (inputChooseAction)
    {
        case 1:
            Console.WriteLine(user.CheckBalance());
            break;
        case 2:
            Console.WriteLine("Enter the amount of dollars you would like to Withdraw:");
            int inputWithdrawAmount = Convert.ToInt32(Console.ReadLine());
            user.CashWithdrawal(inputWithdrawAmount);
            break;
        case 3:
            Console.WriteLine("Enter the amount of dollars you would like to Deposit:");
            int inputDepositAmount = Convert.ToInt32(Console.ReadLine());
            user.CashDeposit(inputDepositAmount);
            break;
        default:
            Console.WriteLine("Error you have entered invalid number.");
            break;
    }
}



