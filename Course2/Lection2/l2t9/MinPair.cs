using System.Collections.Generic;
using System.Linq;

namespace l2t9
{
    public class MinPair : OptimisticCalc
    {
        public override ExerciseResult Calc(int[] numbers)
        {
            List<int> list = new List<int>(numbers);
            ExerciseResult outResult = new ExerciseResult(list.IndexOf(list.Min()), list.Min());
            return outResult;
        }
    }
}