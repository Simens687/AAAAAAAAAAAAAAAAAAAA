
Console.WriteLine("Выберите программу, которую хотите запустить");
Console.WriteLine("1 - Игра: Угадай число");
Console.WriteLine("2 - Таблица умнижения");
Console.WriteLine("3 - Закончить");

int pg = Convert.ToInt32(Console.ReadLine());

while (pg <= 2)
{
    if (pg == 1)
    {
        Random rand = new Random();
        int randint = rand.Next(100);
        Console.WriteLine("Угадай число от 1 до 100 ");
        int pers = Convert.ToInt32(Console.ReadLine());
        while (pers != randint)
        {
            if (pers < randint)
            {
                Console.WriteLine("Нужно больше");
                pers = Convert.ToInt32(Console.ReadLine());
            }
            if (pers > randint)
            {
                Console.WriteLine("Нужно меньше");
                pers = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Ура победа, победа, победа");

    }

    if (pg == 2)
    {
        int[,] table = new int[9, 9];
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                table[i, j] = (i + 1) * (j + 1);
            }
        }

        for (int m = 0; m < 9; m++)
        {
            for (int n = 0; n < 9; n++)
            {
                Console.Write(table[m, n] + "\t");
            }
            Console.WriteLine();
        }
    }

    Console.WriteLine("");
    Console.WriteLine("Выберите программу, которую хотите запустить");
    Console.WriteLine("1 - Игра: Угадай число");
    Console.WriteLine("2 - Таблица умнижения");
    Console.WriteLine("3 - Закончить");
    pg = Convert.ToInt32(Console.ReadLine());
}