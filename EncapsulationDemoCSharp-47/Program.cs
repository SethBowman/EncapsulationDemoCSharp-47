using EncapsulationDemoCSharp_47;

var seth = new Person();

seth.Name = "Seth";
seth.Age = 30;


var money = seth.CheckWallet();
Console.WriteLine(money);

seth.AddMoney(100.00);

money =  seth.CheckWallet();
Console.WriteLine(money);