int heroHealth = 10;
int monsterHealth = 10;
Random random = new Random();

do
{
    int attack = random.Next(1, 10);
    Console.WriteLine($"Monster was damaged and lost {attack} health and now has {monsterHealth -= attack} health");

    if (monsterHealth <= 0)
    {
        continue;
    }

    attack = random.Next(1, 10);
    Console.WriteLine($"Hero was damaged and lost {attack} health and now has {heroHealth -= attack} health");

} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!" : "Monster wins!");