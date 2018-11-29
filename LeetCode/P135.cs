
namespace LeetCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class P135
    {
        public int Candy(int[] ratings)
        {
            int totalCandyCount = 0;
            int preCandyCount = 0;
            int preRate = int.MinValue;
            bool isPreDirectionDown = false;
            int length = 0;

            for (int i = 0; i < ratings.Length; i++)
            {
                if (ratings[i] > preRate)
                {
                    if (isPreDirectionDown == true)
                    {
                        if (preCandyCount < 1)
                        {
                            totalCandyCount += (1 - preCandyCount) * length;

                        }
                        else
                        {
                            totalCandyCount -= (preCandyCount - 1) * (length - 1);
                        }
                        preCandyCount = 1;
                    }

                    var currentCandyCount = preCandyCount + 1;
                    totalCandyCount += currentCandyCount;
                    preCandyCount = currentCandyCount;
                    preRate = ratings[i];
                    isPreDirectionDown = false;
                }
                else if (ratings[i] < preRate)
                {
                    if (isPreDirectionDown == false)
                    {
                        length = 1;
                    }

                    var currentCandyCount = preCandyCount - 1;
                    totalCandyCount += currentCandyCount;
                    preCandyCount = currentCandyCount;
                    preRate = ratings[i];
                    isPreDirectionDown = true;
                    length++;
                }
                else
                {
                    if (isPreDirectionDown == true)
                    {
                        if (preCandyCount < 1)
                        {
                            totalCandyCount += (1 - preCandyCount) * length;
                        }
                        else
                        {
                            totalCandyCount += (1 - preCandyCount) * (length - 1);
                        }
                    }

                    totalCandyCount++;
                    preCandyCount = 1;
                    preRate = ratings[i];
                    length = 1;
                    isPreDirectionDown = true;
                }
            }

            if (isPreDirectionDown == true)
            {
                if (preCandyCount < 1)
                {
                    totalCandyCount += (1 - preCandyCount) * length;

                }
                else
                {
                    totalCandyCount -= (preCandyCount - 1) * (length - 1);
                }
            }
            return totalCandyCount;
        }
    }
}
