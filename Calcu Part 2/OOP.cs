using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcu_Part_2
{
    class OOP
    {
        private String operation = "";
        private Boolean Operation_Used = false;
        public float Value = 0;
        public string Operation { get => operation; set => operation = value; }
        public bool Operation_Used1 { get => Operation_Used; set => Operation_Used = value; }
    }
}
