using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Корпус
    {
        public string Название {get; }
        public string Адрес { get; }
        public Сотрудник Сотрудник { get; }
        public Организация Организация { get; }
        public Корпус(string название, string адрес, Сотрудник сотрудник, Организация организация)
        {
            Название = название;
            Адрес = адрес;
            Сотрудник = сотрудник;
            Организация = организация;
        }
    }
}
