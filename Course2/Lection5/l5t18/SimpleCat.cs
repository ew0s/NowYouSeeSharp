using System;

namespace l5t18
{
    public class SimpleCat
    {
        protected int Mult(int[][] arr)
        {
            if (arr != null)
            {
                if (arr.Length == arr[0].Length)
                {
                    if (arr.Length <= 10 && arr[0].Length <= 10)
                    {
                        bool isNormal = true;
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (arr[i].Length != arr.Length)
                            {
                                isNormal = false;
                            }
                        }
                        if (isNormal)
                        {
                            int result = 1;
                            for (int i = 0; i < arr.Length; i++)
                            {
                                int temp = 0;
                                for (int j = 0; j < arr[i].Length; j++)
                                {
                                    temp += arr[i][j];
                                }
                                result *= temp;
                            }
                            return result;
                        }
                        else
                        {
                            throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                else
                {
                    throw new NotSupportedException();
                }
            }
            else
            {
                throw new NotSupportedException();
            }
        }
    }
}
