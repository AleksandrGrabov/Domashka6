Console.WriteLine("Введите количество чисел:");
        int m = int.Parse(Console.ReadLine());

        int count = 0; // создаем переменную для хранения количества чисел больше 0

        for (int i = 1; i <= m; i++)
        {
            Console.WriteLine($"Введите число {i}:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                count++; // если число больше 0, увеличиваем счетчик на 1
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {count}");

        Console.ReadLine();