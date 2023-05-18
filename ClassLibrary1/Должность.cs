using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Должность
    {
        public string Название { get; }
        public uint Оклад { get; }
        public Подразделение Подразделение { get; }


        public Должность(string название, uint оклад, Подразделение подразделение)
        {
            Название = название;
            Оклад = оклад;
            Подразделение = подразделение;
        }
    }
}
