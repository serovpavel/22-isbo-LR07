using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{

    public class Группа
    {
        public string Название { get; }
        public string Сокращение { get; }
        public byte Численность { get; }
        public ushort ГодПоступления { get; }
        public Специальность Специальность { get; }
        public Сотрудник КлассныйРуководитель { get; }

        public Группа(string название, string сокращение, byte численность, ushort годПоступления, Специальность специальность, Сотрудник сотрудник)
        {
            Название = название;
            Сокращение = сокращение;
            Численность = численность;
            ГодПоступления = годПоступления;
            Специальность = специальность;
            КлассныйРуководитель = сотрудник;
        }
    }
}
