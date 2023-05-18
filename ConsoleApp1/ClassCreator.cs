using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class ClassCreator
    {
        public static Пара Пара()
        {
            Console.Write("Укажите время начала пары: ");
            TimeSpan началоПары = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Укажите время окончания пары: ");
            TimeSpan конецПары = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Укажите время начала перерыва: ");
            TimeSpan началоПерерыва = TimeSpan.Parse(Console.ReadLine());
            Console.Write("Укажите время окончания перерыва: ");
            TimeSpan конецПерерыва = TimeSpan.Parse(Console.ReadLine());
            return new Пара(началоПары, конецПары, началоПерерыва, конецПерерыва, Смена());
        }
        public static Занятие Занятие()
        {
            Console.Write("Введите дату проведения: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime дата))
                return new Занятие(дата, Дисциплина(), Сотрудник(), Аудитория(), Группа(), Пара(), ВидЗанятия());
            else
                return new Занятие(Дисциплина(), Сотрудник(), Аудитория(), Группа(), Пара(), ВидЗанятия());
        }

        public static Аудитория Аудитория()
        {
            byte колвоМест = 0;
            byte колвоОкон = 0;
            Console.Write("Введите название аудитории: ");
            string название = Console.ReadLine();
            Console.Write("Введите количество мест: ");
            if (byte.TryParse(Console.ReadLine(), out byte result1))
            {
                колвоМест = result1;
            }
            Console.Write("Введите количество окон: ");
            if (byte.TryParse(Console.ReadLine(), out byte result2))
            {
                колвоОкон = result2;
            }
            return new Аудитория(название, Сотрудник(), колвоМест, колвоОкон, Оборудование());
        }

        public static Дисциплина Дисциплина()
        {
            Console.Write("Введите дисциплину: ");
            string название = Console.ReadLine();
            Console.Write("Введите сокращение дисциплины: ");
            string сокращение = Console.ReadLine();
            return new Дисциплина(название, сокращение);
        }


        public static Студент Студент()
        {
            DateTime датаРождения;
            byte день, месяц;
            ushort год;      
            Console.Write("Введите фамилию студента: ");
            string фамилия = Console.ReadLine();
            Console.Write("Введите имя студента: ");
            string имя = Console.ReadLine();            
            Console.Write("Введите отчество студента: ");
            string отчество = Console.ReadLine();
            Console.WriteLine("Дата рождения студента: ");
            Console.Write("Введите год рождения: ");
            try
            {
                год = ushort.Parse(Console.ReadLine());
                Console.Write("Введите месяц рождения: ");
                месяц = byte.Parse(Console.ReadLine());
                Console.Write("Введите день рождения: ");
                день = byte.Parse(Console.ReadLine());
                датаРождения = new DateTime(год, месяц, день);
                Console.WriteLine(датаРождения.ToString("dd.MM.yyyy"));
            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный формат даты");
                Console.ResetColor();
                return Студент();
            }

            return new Студент(фамилия, имя, отчество, датаРождения, Группа());
        }
        static bool isDa = false;
        public static Сотрудник Сотрудник()
        {
            isDa = true;
            Console.Write("Введите фамилию сотрудника: ");
            string фамилия = Console.ReadLine();
            Console.Write("Введите имя сотрудника: ");
            string имя = Console.ReadLine();
            Console.Write("Введите отчество : ");
            string отчество = Console.ReadLine();
            return new Сотрудник(фамилия, имя, отчество, Должность());
        }


        public static Смена Смена()
        {
            Console.WriteLine("Введите название смены: ");
            string название = Console.ReadLine();
            return new Смена(название);
        }

        public static Должность Должность()
        {
            uint оклад;
            Console.Write("Введите название должности: ");
            string название = Console.ReadLine();
            Console.Write("Введите оклад: ");
            if(uint.TryParse(Console.ReadLine(), out uint result)) 
            {
                оклад = result;
            }
            else
            {
                Console.WriteLine("Миша, давай по новой");
                return Должность();
            }
            return new Должность(название, оклад, Подразделение());
        }

        public static Подразделение Подразделение()
        {

            Console.Write("Введите название подразделения: ");
            string название = Console.ReadLine();

            if (!isDa)
                return new Подразделение(название, Сотрудник(), Организация());
            else
                return new Подразделение(название, Организация());
        }

        public static Организация Организация()
        {
            isDa = true;
            Console.Write("Введите название организации: ");
            string название = Console.ReadLine();
            Console.Write("Введите юридический адрес: ");
            string юридическийАдрес = Console.ReadLine();
            Console.Write("Введите фактический адрес: ");
            string фактическийАдрес = Console.ReadLine();
            if(!isDa)
             return new Организация(название, юридическийАдрес, фактическийАдрес, Сотрудник());
          else
                return new Организация(название, юридическийАдрес, фактическийАдрес);
        }

        public static Оборудование Оборудование()
        {
            return new Оборудование();
        }

        public static Группа Группа()
        {
            ushort годПоступления;
            byte численность;
            Console.Write("Введите название группы: ");
            string название = Console.ReadLine();
            Console.Write("Введите сокращение: ");
            string сокращение = Console.ReadLine();
            Console.Write("Введите численность: ");
            if(byte.TryParse(Console.ReadLine(), out byte result1) && result1 > 0 && result1 <= 34)
            {
                численность = result1;
            }
            else
            {
                Console.WriteLine("М-даа.....");
                return Группа();
            }
            Console.Write("Введите год поступления: ");
            if(ushort.TryParse(Console.ReadLine(), out ushort result) && result > 1949 && result <= DateTime.Now.Year)
            {
                годПоступления = result;
            }
            else
            {
                Console.WriteLine("Ты адекватный?");
                    return Группа();
            }
            return new Группа(название, сокращение, численность, годПоступления, Специальность(), Сотрудник());
        }

        public static Корпус Корпус()
        {
            Console.Write("Введите название корпуса: ");
            string название = Console.ReadLine();
            Console.Write("Введите адрес: ");
            string адрес = Console.ReadLine();
            return new Корпус(название, адрес, Сотрудник(), Организация());
        }
        public static Специальность Специальность()
        {
            Console.Write("Введите название специальности:");
            string название = Console.ReadLine();
            Console.Write("Введите сокращение:");
            string сокращение = Console.ReadLine();
            return new Специальность(название, сокращение);
        }

        public static ВидЗанятия ВидЗанятия()
        {
            Console.Write("Введите вид занятия: ");
            string ВидЗанятия = Console.ReadLine();

            return new ВидЗанятия(ВидЗанятия);
        }
    }
}
