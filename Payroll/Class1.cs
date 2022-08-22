using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    public class Testttt
    {
        public static void main()
        {
            int[] result = new int[] { 1, 3, 5, 7, 9 };
            int target = 9;

            Testttt.TwoSum(result, target);
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            for(int i=0; i <= nums.Length; i++)
            {
                for(int j = 1; i <= nums.Length; i++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j ;
                        break;
                    }
                }
            }


            return result;
        }
    }

}
