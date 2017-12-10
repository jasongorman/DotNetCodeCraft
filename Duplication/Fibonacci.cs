using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplication
{
    public class Fibonacci
    {
        public long Calculate(int index)
        {
            if(index < 0) throw new ArgumentException();

            long[] sequence = new long[index+1];

            for (int i = 0; i <= index; i++)
            {
                if (i < 2)
                {
                    sequence[i] = i;
                }
                else
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
            }
            return sequence[index];
        }
    }
}
