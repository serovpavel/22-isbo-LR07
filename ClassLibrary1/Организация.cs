using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Организация
    {
        public string Название { get; }
        public string ЮридическийАдрес { get; }
        public string ФактическийАдрес { get; }
        public Сотрудник Руководитель { get; }

        public Организация(string название, string юридическийАдрес, string фактическийАдрес, Сотрудник руководитель)
        {
            Название = название;
            ЮридическийАдрес = юридическийАдрес;
            ФактическийАдрес = фактическийАдрес;
            Руководитель = руководитель;
        }
        public Организация(string название, string юридическийАдрес, string фактическийАдрес)
        {
            Название = название;
            ЮридическийАдрес = юридическийАдрес;
            ФактическийАдрес = фактическийАдрес;            
        }
    }
}
