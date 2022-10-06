int num1;
string method;
int num2;
int addition;
int subtraction;
int mod;
int division;
int multi;
char choice;

do
{
    try
    {
        Console.WriteLine("Please input number one");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input the operator you want to use: ");
        method = Console.ReadLine();

        Console.WriteLine("Please input number two: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        switch (method)
        {
            case "+":
                Console.WriteLine("You have chosen the addition operator");
                addition = num1 + num2;
                Console.WriteLine("This is the end result of your addition: " + addition);
                break;

            case "-":
                Console.WriteLine("You have chosen the subtraction operator");
                subtraction = num1 - num2;
                Console.WriteLine("This is the end result of your subtraction: " + subtraction);
                break;

            case "*":
                Console.WriteLine("You have chosen the multiplication operator");
                multi = num1 * num2;
                Console.WriteLine("This is the end result of your multiplication: " + multi);
                break;

            case "/":
                Console.WriteLine("You have chosen the division operator");
                division = num1 / num2;
                Console.WriteLine("This is the end result of your division: " + division);
                break;

            case "%":
                Console.WriteLine("You have chosen the mod operator");
                mod = num1 % num2;
                Console.WriteLine("This is the end result of your mod " + mod);
                break;


        }
        
    }
    catch
    { 
        Console.WriteLine("Invalid");
    }
    Console.WriteLine("Do you want to continue? ");
    choice = Convert.ToChar(Console.ReadLine());
}
while (choice != 'N');
Console.ReadKey();

/* random number 
random rand = new random();
int number = rand.next(0, 100); */

































/*int user_input1, user_input2, user_input3, user_input4, user_input5, user_input6;
int average;
char choice;


do
{
    try
    {
        Console.WriteLine("Please enter your first number");
        user_input1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your second number");
        user_input2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your third number");
        user_input3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your fourth number");
        user_input4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your fifth number");
        user_input5 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your final number");
        user_input6 = Convert.ToInt32(Console.ReadLine());

        average = (user_input1 + user_input2 + user_input3 + user_input4 + user_input5 + user_input6) / 6;

        switch (average)
        {
            case >= 70:
                Console.WriteLine("You've got a first");
                break;

            case >= 60:
                Console.WriteLine("You've got a 2:2 ");
                break;

            case >= 50:
                Console.WriteLine("You've got a 2:1");
                break;

            case > 40:
                Console.WriteLine("You've got a 3rd");
                break;

            case >= 40:
                Console.WriteLine("You've passed");
                break;

            case < 39:
                Console.WriteLine("You've failed ");
                break;
        }
    }
    catch
    {
        Console.WriteLine("Invalid format");
    }
    Console.WriteLine("Do you want to try again? ");
    choice = Convert.ToChar(Console.ReadLine());

}
while(choice != 'N');
Console.ReadKey(); */






