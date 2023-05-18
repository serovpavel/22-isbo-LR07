using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    static class UI
    {
        public static void Print(Пара пара)
        {
            Console.WriteLine($"Время начала пары = {пара.НачалоПары}");
            Console.WriteLine($"Время окончания пары = {пара.КонецПары}");
            Console.WriteLine($"Время начала перерыва = {пара.НачалоПерерыва}");
            Console.WriteLine($"Время окончания перерыва = {пара.КонецПерерыва}");
            Print(пара.Смена);
        }
        public static void Print(Занятие занятие)
        {
            Console.WriteLine($"Дата проведения занятия = {занятие.Дата}");
            Print(занятие.Дисциплина);
            Print(занятие.Сотрудник);
            Print(занятие.Аудитория);
            Print(занятие.Группа);
            Print(занятие.Пара);
            Print(занятие.ВидЗанятия);
        }
        public static void Print(Аудитория аудитория)
        {
            Console.WriteLine($"Название аудитория = {аудитория.Название}");
            Print(аудитория.Сотрудник);
            Console.WriteLine($"Количество мест = {аудитория.КолвоМест}");
            Console.WriteLine($"Количество окон = {аудитория.КолвоОкон}");
            Print(аудитория.Оборудование);
        }

        public static void Print(Дисциплина дисциплина)
        {
            Console.WriteLine($"Название дисциплины: {дисциплина.Название}");
            Console.WriteLine($"Сокращение дисциплины: {дисциплина.Сокращение}");
        }

        public static void Print(Группа группа)
        {
            Console.WriteLine($"Название группы = {группа.Название}");
            Console.WriteLine($"Сокращение = {группа.Сокращение}");
            Console.WriteLine($"Численность = {группа.Численность}");
            Console.WriteLine($"ГодПоступления = {группа.ГодПоступления}");
            Print(группа.КлассныйРуководитель);
            Print(группа.Специальность);
        }

        public static void Print(Студент студент)
        {
            Console.WriteLine($"Фамилия студента = {студент.Фамилия}");
            Console.WriteLine($"Имя студента = {студент.Имя}");
            Console.WriteLine($"Отчество студента = {студент.Отчество}");
            Console.WriteLine($"Дата рождения студента = {студент.ДатаРождения}");
            Print(студент.Группа);
        }

        public static void Print(Смена смена)
        {
            Console.WriteLine($"Название смены: {смена.Название}");
        }

        public static void Print(Сотрудник сотрудник)
        {
            if (сотрудник != null)
            {
                Console.WriteLine($"Фамилия сотрудника: {сотрудник.Фамилия}");
                Console.WriteLine($"Имя сотрудника: {сотрудник.Имя}");
                Console.WriteLine($"Отчество сотрудника: {сотрудник.Отчество}");
                Print(сотрудник.Должность);
            }
        }

        public static void Print(Должность должность)
        {
            Console.WriteLine($"Должность: {должность.Название}");
            Console.WriteLine($"Оклад: {должность.Оклад}");
            Print(должность.Подразделение);

        }
        public static void Print(Специальность специальность)
        {
            Console.WriteLine($"Название специальности:{специальность.Название}");
            Console.WriteLine($"Сокращение:{специальность.Сокращение}");
        }
        public static void Print(Подразделение подразделение)
        {
            Console.WriteLine($"Название подразделения: {подразделение.Название}");
            Print(подразделение.Сотрудник);
            Print(подразделение.Организация);
        }

        public static void Print(Организация организация)
        {
            if (организация != null)
            {
                Console.WriteLine($"Название организации = {организация.Название}");
                Console.WriteLine($"Юридический адрес = {организация.ЮридическийАдрес}");
                Console.WriteLine($"Фактический адрес = {организация.ФактическийАдрес}");
                Print(организация.Руководитель);
            }
        }

        public static void Print(ВидЗанятия видЗанятия)
        {
            Console.WriteLine($"Вид занятия: {видЗанятия.Название}");
        }

        public static void Print(Оборудование оборудование)
        {

        }

        public static void Print(Корпус корпус)
        {
            Console.WriteLine($"Название корпуса: {корпус.Название}");
            Console.WriteLine($"Адрес корпуса: {корпус.Адрес}");
            Print(корпус.Сотрудник);
            Print(корпус.Организация);
        }
    }
}
