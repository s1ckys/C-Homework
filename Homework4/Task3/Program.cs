using Task3;

Customer[] customers =
   {
        new Customer("Bob Bobsky", 1234123412341234, 4325, 650),
        new Customer("Jane Smith", 1111222233334444, 1234, 1200),
        new Customer("John Doe", 7768667855674456, 6644, 960)
    };

void AtmApp()
{
    while (true)
    {
        Console.WriteLine("Welcome to the ATM app");
        Console.WriteLine("Please enter your card number (format: 1234-1234-1234-1234):");

        bool successParseLong = long.TryParse(Console.ReadLine(), out long cardNumber);
        if (!successParseLong)
        {
            Console.WriteLine("Invalid card number format.\n");
            continue;
        }

        Customer existingCustomer = FindCustomer(customers, cardNumber);
        if (existingCustomer == null)
        {
            string choice;
            do
            {
                Console.WriteLine("Card not found. Do you want to register a new account? (yes/no)");
                choice = Console.ReadLine().Trim().ToLower();

                if (choice == "yes")
                {
                    RegisterNewCustomer(cardNumber);
                }
                else if (choice == "no")
                {
                    Console.WriteLine("Returning to main menu...");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }

            } while (choice != "yes" && choice != "no");

            if (choice == "no")
            {
                continue;
            }

            existingCustomer = FindCustomer(customers, cardNumber);
        }

        Console.WriteLine("Enter Pin:");
        bool successParseInt = int.TryParse(Console.ReadLine(), out int pin);
        if (!successParseInt)
        {
            Console.WriteLine("Invalid PIN format.\n");
            continue;
        }

        if (!existingCustomer.Authenticate(pin))
        {
            Console.WriteLine("Wrong PIN!\n");
            continue;
        }

        Console.WriteLine($"Welcome {existingCustomer.FullName}!");

        bool continueSession = true;
        while (continueSession)
        {
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("1) Check Balance");
            Console.WriteLine("2) Cash Withdrawal");
            Console.WriteLine("3) Cash Deposit");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine($"Your current balance is {existingCustomer.GetBalance()}$");
                    break;

                case "2":
                    Console.WriteLine("Enter amount to withdraw:");
                    bool successParseWithdraw = double.TryParse(Console.ReadLine(), out double withdrawAmount);
                    if (successParseWithdraw)
                    {
                        if (existingCustomer.Withdraw(withdrawAmount))
                        {
                            Console.WriteLine($"You withdrew {withdrawAmount}$. You have {existingCustomer.GetBalance()}$ left.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter amount to deposit:");
                    bool successParseDeposit = double.TryParse(Console.ReadLine(), out double depositAmount);
                    if (successParseDeposit)
                    {
                        existingCustomer.Deposit(depositAmount);
                        Console.WriteLine($"Deposit successful! New balance: {existingCustomer.GetBalance()}$");
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

            string continueChoice;
            do
            {
                Console.WriteLine("Would you like to perform another action? (yes/no)");
                continueChoice = Console.ReadLine().Trim().ToLower();
                if (continueChoice != "yes" && continueChoice != "no")
                {
                    Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
                }
            } while (continueChoice != "yes" && continueChoice != "no");

            if (continueChoice != "yes")
            {
                continueSession = false;
                Console.WriteLine("Thank you for using the ATM app!\n");
                break;
            }
        }
        break;
    }
}

bool TryParseCardNumber(string input, out long number)
{
    input = input.Replace("-", "");
    return long.TryParse(input, out number);
}

Customer FindCustomer(Customer[] customers, long cardNumber)
{
    foreach (var customer in customers)
    {
        if (customer.CardNumber == cardNumber)
        {
            return customer;
        }
    }
    return null;
}

void RegisterNewCustomer(long cardNumber)
{
    if (FindCustomer(customers, cardNumber) != null)
    {
        Console.WriteLine("User already exists!");
        return;
    }

    Console.WriteLine("Enter full name:");
    string name = Console.ReadLine();

    Console.WriteLine("Enter PIN (4 digits):");
    bool successParseNewPin = int.TryParse(Console.ReadLine(), out int newPin);
    if (!successParseNewPin || newPin < 1000 || newPin > 9999)
    {
        Console.WriteLine("Invalid PIN format. Registration cancelled.");
        return;
    }

    Console.WriteLine("Enter initial balance:");
    bool successParseInitialBalance = double.TryParse(Console.ReadLine(), out double balance);
    if (!successParseInitialBalance)
    {
        Console.WriteLine("Invalid balance amount. Registration cancelled.");
        return;
    }

    Array.Resize(ref customers, customers.Length + 1);
    customers[customers.Length - 1] = new Customer(name, cardNumber, newPin, balance);

    Console.WriteLine("Successfully registered!");
    Console.WriteLine("-----------------");
    Console.WriteLine("Customers registered so far:");
    Console.WriteLine("-----------------");

    foreach (Customer c in customers)
    {
        Console.WriteLine($"Card Number: {c.CardNumber}, Name: {c.FullName}");
    }

    Console.WriteLine("---------------------");
}

AtmApp();
