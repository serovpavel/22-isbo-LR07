using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Какой класс Вы хотите создать: ");
                switch (Console.ReadLine())
                {
                    case "Пара": UI.Print(ClassCreator.Пара()); break;
                    case "Подразделение": UI.Print(ClassCreator.Подразделение()); break;
                    case "Должность": UI.Print(ClassCreator.Должность()); break;
                    case "Специальность": UI.Print(ClassCreator.Специальность()); break;
                    case "Дисциплина": UI.Print(ClassCreator.Дисциплина()); break;
                    case "Студент": UI.Print(ClassCreator.Студент());break;
                    case "Сотрудник": UI.Print(ClassCreator.Сотрудник()); break;
                    case "Аудитория": UI.Print(ClassCreator.Аудитория()); break;
                    case "Занятие": UI.Print(ClassCreator.Занятие()); break;
                    case "Организация": UI.Print(ClassCreator.Организация()); break;
                    case "Вид Занятия": UI.Print(ClassCreator.ВидЗанятия()); break;
                    case "Группа": UI.Print(ClassCreator.Группа()); break;
                    case "Смена": UI.Print(ClassCreator.Смена()); break;
                    case "Корпус": UI.Print(ClassCreator.Корпус()); break;
                    default: Console.WriteLine("Такой класс не реализован"); break;
                }
            }
        }
    }
}
