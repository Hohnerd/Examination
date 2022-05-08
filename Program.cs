/*  Написать программу, которая из имеющегося массива строк формирует массив из строк, 
    длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
    либо задать на старте выполнения алгоритма. */
            const int index = 6;
            string[] s = new string[index] {"Denmark","cat","-2","world","war","Moscow"};
            string[] s2 = new string[index];
            int j = 0;

            FindingArrayElements();
            PrintNewArray();

            // поиск элементов удовлетворяющих условиям задачи
            void FindingArrayElements ()
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i].Length <= 3)
                    {
                        s2[j] = s[i];
                        j++;
                    }
                }
            }
            // вывод нового массива на экран
            void PrintNewArray ()
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write(s2[i] + "\t");
                }
            }
            Console.ReadKey();
