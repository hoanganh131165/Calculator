using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTapKTPM
{
    public class Calculation
    {
        private int a;
        private int b;
        public  void Calculaion(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int Execute(string operation)
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = this.a + this.b;
                    break;
                case "-":
                    result = this.a - this.b;
                    break;
                case "*":
                    result = this.a * this.b;
                    break;
                case "/":
                    result = this.a / this.b;
                    break;
            }
            return result;
        }
    }
}
       
