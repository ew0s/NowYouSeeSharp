using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t8
{
    public class Cat
    {
        public string Name { get; set; }
        public int Money { get; set; }

        public string Describe()
        {
            if (Money < 5000)
            {
                return $"Тяжела жизнь котика {Name}, у него всего-лишь {Money} кошачьих денежек...";
            }
            else
            {
                return $"Я мажу чёрную икру вместо масла...";
            }
        }

        public virtual void DoWork(int payment)
        {
            throw new NotImplementedException();
        }
    }
}
