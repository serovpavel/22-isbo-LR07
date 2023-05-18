
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Пара
    {
        public TimeSpan НачалоПары { get; }
        public TimeSpan КонецПары { get; }
        public TimeSpan НачалоПерерыва { get; }
        public TimeSpan КонецПерерыва { get; }
        public Смена Смена { get; }
        public Пара(TimeSpan началоПары, TimeSpan конецПары, TimeSpan началоПерерыва, TimeSpan конецПерерыва, Смена смена)
        {
            НачалоПары = началоПары;
            КонецПары = конецПары;
            НачалоПерерыва = началоПерерыва;
            КонецПерерыва = конецПерерыва;
            Смена = смена;
        }
    }
}
