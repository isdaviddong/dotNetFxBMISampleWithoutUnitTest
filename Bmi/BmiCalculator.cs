using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bmi
{
    public class BmiCalculator
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public float BMI
        {
            get
            {
                return Calculate();
            }
        }


        public float Calculate()
        {
            float result = 0;
            //將float改成int試試看
            float height = (float)Height / 100;
            result = Weight / (height * height);

            return result;
        }
    }
}
