using System;
using System.Collections.Generic;

namespace CS_ES
{
    class QA
    {
        public string Question { get; set; }
        public List<string> Answer { get; set; }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            var listQA = new List<QA>();
        var qa1 = new QA
        {
            Question = "Тестовый вопрос 1",
            Answer = new List<string>
            {
                "A1",
                "B1",
                "C1"
            }
        };
        var qa2 = new QA
        {
            Question = "Тестовый вопрос 2",
            Answer = new List<string>
            {
                "A2",
                "B2",
                "C2"
            }
        };
        var qa3 = new QA
        {
            Question = "Тестовый вопрос 3",
            Answer = new List<string>
            {
                "A3",
                "B3",
                "C3"
            }
        };
        listQA.Add(qa1);
        listQA.Add(qa2);
        listQA.Add(qa3);




            var listQuestion = new List<string>();
            listQuestion.Add("Первый вопрос");
            listQuestion.Add("Второй вопрос");
            listQuestion.Add("Третий вопрос");
            listQuestion.Add("Четвёртый вопрос");

            var listAnswers1 = new List<string>(){"Перый ответ","Второй ответ","Третий ответ","Четвёртый ответ"};
            


            Console.Write("Введите Ф.И.О.: ");
            string name = Console.ReadLine();
            Console.Write("Выберите параметры (1-начать, 2-выход)");
            
            int l = new int();
            int p = new int();
            
            
            GetInput(out l);

            switch (l)
            {
                case 1:

                    int[] num = new int[5];

                        Console.WriteLine("1-Параметр 1\n2-Параметр 2\n3-Параметр 3\n4-Параметр 4\n5-Параметр 5");

                    for (int i = 0; i < num.Length; i++)
                    {
                        GetInput(out p);
                        switch (p)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                        }
                    }
                    Console.WriteLine($"Были выбраны параметры: {p}");

                    // for (int t = 0; t < num.Length; t++)
                    // {
                    //     num[t] = int.Parse(Console.ReadLine());
                    // }

                    // Console.WriteLine("Вывод: ");
                    // for (int t = 0; t < num.Length; t++)
                    // {
                    //     Console.WriteLine(num[t]);
                    // }

                    break;


                case 2:
                    break;
            }


        }

        static void GetInput(out int y)
        {
            while(!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Неверное значение");
            }
        }
    }
}
