int password = 1234;
int moneyInBank = 1000;
int tries = 0;

Console.WriteLine("What is the Password? ");
int userCode = int.Parse(Console.ReadLine());
tries++;

while (userCode != password){
    if(tries==3){
        Console.WriteLine("Goodbye!");
        Environment.Exit(0);
    }
    Console.WriteLine("Try again ");
    userCode = int.Parse(Console.ReadLine());
    tries++;
}

Console.WriteLine("Password correct. How much do you want? ");
int userMoney = int.Parse(Console.ReadLine());

while ( userMoney > moneyInBank){
    Console.WriteLine("You want too much...");
    userMoney = int.Parse(Console.ReadLine());
}
while ( userMoney < 1){
    Console.WriteLine("You cant do that...");
    userMoney = int.Parse(Console.ReadLine());
}
moneyInBank = moneyInBank - userMoney;
Console.WriteLine("Your money is: "+moneyInBank);
