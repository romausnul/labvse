using System;

namespace ВОПРОСЫ__ОТВЕТЫ
{
    class Program
    {
        private const string V = "Проц";

        static void Main()
            {
            next:
                Random question = new Random();
                int x = question.Next(5);
                string[] array = new string[5];
                array[0] = "Устройства ввода информации";
                array[1] = "Устройства вывода информации";
                array[2] = "Обратка информации";
                array[3] = "Какие есть ОС? перечислить два штука";
                array[4] = "Перечислите составляющие ПК";

               Console.WriteLine(array[x]);

                string[] answer = new string[5];
                answer[0] = "Мышь";
                answer[1] = "Принтер";
                answer[2] = "Проц";
                answer[3] = "Винда";
                answer[4] = "Материнская плата";
                
            string a = Console.ReadLine();

                if (a == answer[x])
                {
                    Console.WriteLine("Ты помоему правильно  \n*Оценка 4:");
                    goto next;
                }
                else
                    Console.WriteLine("Ты вроде попутал \n*НУ пж попробуй ещё раз.");

                Console.ReadLine();
            }
    }
}
