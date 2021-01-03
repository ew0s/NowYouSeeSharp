using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t8
{
    public class CatTeacher : Cat
    {
        public int Money { get; set; }
        public override void DoWork(int payment)
        {
            base.Money += payment;
        }
    }
}
