Random coin = new Random();
int flip = coin.Next(2);
Console.WriteLine(flip == 1 ? "Heads" : "Tails");