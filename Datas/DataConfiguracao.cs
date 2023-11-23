using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    internal class DataConfiguracao
    {
        public DataConfiguracao() 
        {
            Formato = 1;
        }

        private byte Formato { set; get; }

        private List<DateTime> ListaDatasImportanteTI
        {

            get => new List<DateTime>()
            {
                new DateTime(1946, 8, 15),
                new DateTime(1969, 4, 17),
                new DateTime(1912, 6, 23)
            };
        }
    }
}
