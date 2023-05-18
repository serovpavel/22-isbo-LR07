using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// занятие
/// </summary>
namespace ClassLibrary1
{
    public class Занятие
    {
        public DateTime Дата { get; }
        public Дисциплина Дисциплина { get; }
        public Сотрудник Сотрудник { get; }
        public Аудитория Аудитория { get; }
        public Группа Группа { get; }
        public Пара Пара { get; }
        public ВидЗанятия ВидЗанятия { get; }

        public Занятие(DateTime дата, Дисциплина дисциплина, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, ВидЗанятия видЗанятия)
        {
            Дата = дата;
            Дисциплина = дисциплина;
            Сотрудник = сотрудник;
            Аудитория = аудитория;
            Группа = группа;
            Пара = пара;
            ВидЗанятия = видЗанятия;
        }
        public Занятие(Дисциплина дисциплина, Сотрудник сотрудник, Аудитория аудитория, Группа группа, Пара пара, ВидЗанятия видЗанятия) : this (DateTime.Now,дисциплина, сотрудник,аудитория,группа,пара,видЗанятия )
        {
        }
    }
}
