string login = Console.ReadLine();

char[] passowrd = login.Reverse().ToArray();
string passwordString = new string(passowrd);
int attempts = 1;

while (true)
{
    string newPassword = Console.ReadLine();

    if (passwordString == newPassword)
    {
        Console.WriteLine($"User {login} logged in. ");
        return;
    }
    else
    {
        if (attempts == 4)
        {
            Console.WriteLine($"User {login} blocked!");
            return;
        }
        Console.WriteLine("Incorrect password. Try again.");
        attempts++;

    }

}

