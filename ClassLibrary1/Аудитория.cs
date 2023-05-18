using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Аудитория
    {
        public string Название { get; }
        public Сотрудник Сотрудник { get; }
        public byte КолвоМест { get; }
        public byte КолвоОкон { get; }
        public Оборудование Оборудование { get; }

        public Аудитория(string название, Сотрудник сотрудник, byte колвоМест, byte колвоОкон, Оборудование оборудование)
        {
            Название = название;
            Сотрудник = сотрудник;
            КолвоМест = колвоМест;
            КолвоОкон = колвоОкон;
            Оборудование = оборудование;
        }
    }
}
