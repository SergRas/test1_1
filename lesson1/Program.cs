// Задаем исходный массив строк
            string[] array = { "Hello", "2", "world", ":-)","1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };

            // Подсчитываем количество строк, подходящих под условие
            int array_size = 0;
            foreach (string str in array)
            {
                if (str.Length <= 3)
                {
                    array_size++;
                }
            }

            // Создаем новый массив подходящего размера
            string[] newArray = new string[array_size];

            // Заполняем новый массив подходящими строками
            int index = 0;
            foreach (string str in array)
            {
                if (str.Length <= 3)
                {
                    newArray[index++] = str;
                }
            }

            // Выводим исходный и новый массивы
            Console.WriteLine("Исходный массив:");
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("\nНовый массив с длиной строки <= 3):");
            foreach (string str in newArray)
            {
                Console.WriteLine(str);
            }