using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni0603
{
    internal class ListNumbers : List<int>
    {

        private int maximum;
        private int minimum;
        public int Maximum { get; }
        public int Minimum { get; }


        public void Max()
        {
            maximum = this.Select(x => x).Max();
        }
        public void Min()
        {
            minimum = this.Select(x => x).Min();
        }



    }
}
