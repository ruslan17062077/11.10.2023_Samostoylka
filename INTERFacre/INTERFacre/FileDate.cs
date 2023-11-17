using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFacre
{
    internal class FileDate : IDatePROVADER
    {
        public void GetDate()
        {
            Console.WriteLine("Данные из файла");
        }
    }
}
