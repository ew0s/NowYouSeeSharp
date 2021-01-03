using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l2t9
{
    public class OptimisticCalc
    {
        public virtual ExerciseResult Calc(int[] numbers)
        {
            List<int> list = new List<int>(numbers);
            ExerciseResult outResult = new ExerciseResult(list.IndexOf(list.Max()), list.Max());
            return outResult;
        }
    }
}
