using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    
    public class Sums
    {
        public SumDelegate PaymentSum { get; } = (Student student) => student.Paid;
        public SumDelegate NeedToPaySum { get; } = (Student student) => student.NeedToPay;
    }
}
