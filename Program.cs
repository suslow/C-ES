using System;
using System.Collections.Generic;

namespace CS_ES
{
    public class ItemQA
    {
        public string Question { get; set; }
        public List<string> AnswerOptions { get; set; }
        public int Result { get; set; }
        public List<string> List_ans {get; set;}
    }

    class Person
    {
        public string Name { get; set; }
    }

    partial class Program
    {

        static void Main(string[] args)
        {

            var listQA = new List<ItemQA>();
            var qa1 = new ItemQA
            {
                Question = "Тестовый вопрос 1",
                AnswerOptions = new List<string>
            {
                "A1",
                "B1",
                "C1"
            }
            };
            var qa2 = new ItemQA
            {
                Question = "Тестовый вопрос 2",
                AnswerOptions = new List<string>
            {
                "A2",
                "B2",
                "C2"
            }
            };
            var qa3 = new ItemQA
            {
                Question = "Тестовый вопрос 3",
                AnswerOptions = new List<string>
            {
                "A3",
                "B3",
                "C3"
            }
            };
            listQA.Add(qa1);
            listQA.Add(qa2);
            listQA.Add(qa3);

            var select = new int();
            var output = "";

            var Sec_List = new List<ItemQA>();

            foreach (var lQA in listQA)
            {
                Console.WriteLine(lQA.Question);


                foreach (var ans in lQA.AnswerOptions)
                {
                    Console.WriteLine(ans);
                }

                Console.WriteLine("Выберите номер ответа ");
                select = Convert.ToInt32(Console.ReadLine());
                output = lQA.AnswerOptions[select];
                Console.WriteLine($"Был выбран: {output}");
                Sec_List.Add(new ItemQA() {List_ans = output);

            }

            var select_ans = "";
            foreach (var item in collection)
            {
                
            }





            Console.Write("Введите Ф.И.О.: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Введёные ФИО: {name}");
            for (int i1 = 0; i1 < 3; i1++)
            {
                Console.WriteLine($"Вопросы:");
                
                for (int i2 = 0; i2 < 3; i2++)
                {
                    Console.WriteLine($"Выбранные ответы: {output}");
                }

            }


            // Console.Write("Выберите параметры (1-начать, 2-выход)");

            // int l = new int();
            // int p = new int();


            // GetInput(out l);

            // switch (l)
            // {
            //     case 1:

            //         int[] num = new int[5];

            //         Console.WriteLine("1-Параметр 1\n2-Параметр 2\n3-Параметр 3\n4-Параметр 4\n5-Параметр 5");

            //         for (int i = 0; i < num.Length; i++)
            //         {
            //             GetInput(out p);

            //             switch (p)
            //             {
            //                 case 1:
            //                     break;
            //                 case 2:
            //                     break;
            //                 case 3:
            //                     break;
            //                 case 4:
            //                     break;
            //                 case 5:
            //                     break;
            //             }
            // Console.WriteLine($"Были выбраны параметры: {p}");
            // }

            // for (int t = 0; t < num.Length; t++)
            // {
            //     num[t] = int.Parse(Console.ReadLine());
            // }

            // Console.WriteLine("Вывод: ");
            // for (int t = 0; t < num.Length; t++)
            // {
            //     Console.WriteLine(num[t]);
            // }

            //         break;


            //     case 2:
            //         break;
            // }



        }


        static void GetInput(out int y)
        {
            while (!int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Неверное значение");
            }
        }
    }
}
