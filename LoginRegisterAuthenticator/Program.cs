using System.ComponentModel.DataAnnotations;

Menu();

void Menu()
{
    Console.Clear();
    Console.WriteLine("0. Exit");
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Forgot Password");
    short option = short.Parse(Console.ReadLine());


    switch (option)
    {
        case 0: System.Environment.Exit(0); break;
        case 1: Register(); break;
        case 2: Login(); break;
        case 3: ForgotPassword(); break;
    }
}
void Register()
{
    Console.Clear();
    Console.WriteLine("Register");
    Console.WriteLine("Enter your username: ");
    string username = Console.ReadLine();
    Console.WriteLine("Enter your password: ");
    string password = Console.ReadLine();
    Console.WriteLine("Confirm your password: ");
    string confirmPassword = Console.ReadLine();

    if (password != confirmPassword) /*valida senha*/
    {
        Console.WriteLine("passwords don't match");
    }
    else
    {
        Console.WriteLine("Register successfully");
    }
}
void Login()
{
    Console.Clear();
    Console.WriteLine("Login");
}
void ForgotPassword()
{
    Console.Clear();
    Console.WriteLine("Forgot Password");
}
