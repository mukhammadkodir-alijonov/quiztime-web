using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizTime.Service.Common.Exceptions
{
    public class InvalidExcel : Exception
    {
        public string Mes { get; set; } = String.Empty;
        public InvalidExcel()
        {
            this.Mes = "Invalid excel table";
        }
    }
}
