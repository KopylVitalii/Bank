using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Money
    {
        public decimal _Total;
        public int _Integer;
        public int _Kopecks;
        public Money() { }
        //public int Integer { get; set; }
        //public int Kopecks { get; set; }
        public async Task OutSum(decimal Sum) 
        {
            if (Sum < _Total)
            {
                _Total -= Sum;
                _Integer = (int)_Total;
                _Kopecks = (int)((_Total - _Integer) * 100);
            }
            else {
                Console.WriteLine("На рахунку не достатньо коштів");
            }
        }
        public async Task InSum(decimal Sum)
        {
            _Total += Sum;
            _Integer = (int)_Total;
            _Kopecks = (int)((_Total - _Integer) * 100);
        }
    }
}
