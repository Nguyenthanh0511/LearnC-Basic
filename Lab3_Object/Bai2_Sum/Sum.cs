using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Sum
{
    public class Sum
    {
        private int[] array;
        public Sum()
        {

        }
        public Sum(int[] a)
        {
            this.array = a;
        }

        public int TinhTong()
        {
            //Sum eachSum = new Sum();
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            return sum;
        }
        
    }
}
