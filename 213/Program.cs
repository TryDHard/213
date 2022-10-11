Console.WriteLine("Добро пожаловать!");

Console.WriteLine("Выберите приложение:");

Console.WriteLine("1) Игра угадай число.");
Console.WriteLine("2) Таблица умножения.");
Console.WriteLine("3) Вывод делителей числа.");
Console.WriteLine("4) Выход.");

Console.WriteLine("Введите номер программы: ");

int prog = Convert.ToInt32(Console.ReadLine());

while (prog != 4)
{
    while (prog == 1)
    {

        int int1;
        int int2;

        Console.WriteLine("Введите диапазон от 0 до:  ");

        int1 = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();
        int sr = rand.Next(int1);

        Console.Clear();

        Console.WriteLine("Компьютер загадал число от 0 до " + int1 + ". Попробуйте отгадать его.");
        Console.WriteLine("Введите число:");

        do
        {

            int2 = Convert.ToInt32(Console.ReadLine());

            if (int2 > sr)
            {

                Console.WriteLine("Вы ввели число: " + int2 + " загаданное число меньше.");

            }
            else
                Console.WriteLine("Вы ввели число: " + int2 + " загаданное число больше.");

        } while (sr != int2);

        Console.WriteLine("Бинго! Это число: " + sr);

        Console.WriteLine("Выберите приложение:");

        Console.WriteLine("1) Игра угадай число.");
        Console.WriteLine("2) Таблица умножения.");
        Console.WriteLine("3) Вывод делителей числа.");
        Console.WriteLine("4) Выход.");

        Console.WriteLine("Введите номер программы: ");

        prog = Convert.ToInt32(Console.ReadLine());


    }

    //while (prog == 2)
    //{

        //int[,] array = new int[10, 10];

        //for (int i = 0; i <= 10, i++)
        //{
            //for (int j = 0; j <= 10, j++)
            //{
                //Console.WriteLine([i, j] + " ");

        //Console.WriteLine();



        //Console.WriteLine("Выберите приложение:");

        //Console.WriteLine("1) Игра угадай число.");
        //Console.WriteLine("2) Таблица умножения.");
        //Console.WriteLine("3) Вывод делителей числа.");
        //Console.WriteLine("4) Выход.");

        //Console.WriteLine("Введите номер программы: ");

    //}

    while (prog == 3)
    {

        Console.Write("Введите число ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        int i = 0;
        while (i != a)
        {
            i++;
            if (a % i == 0)
                Console.WriteLine("{0} Делится на {1} без остатка", a, i);
        }

        Console.WriteLine("");

        Console.WriteLine("Выберите приложение:");

        Console.WriteLine("1) Игра угадай число.");
        Console.WriteLine("2) Таблица умножения.");
        Console.WriteLine("3) Вывод делителей числа.");
        Console.WriteLine("4) Выход.");

        Console.WriteLine("Введите номер программы: ");

    }

}

