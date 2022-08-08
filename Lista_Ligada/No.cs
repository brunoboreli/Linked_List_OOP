using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_Ligada
{
    class No
    {
        //atibutes
        private No prev;
        private int dado;
        private No prox;

        //constructors
        public No Prev { get => prev; set => prev = value; }
        public int Dado { get => dado; set => dado = value; }
        public No Prox { get => prox; set => prox = value; }

        public void init()
        {
            this.prev = null;
            this.dado = 0;
            this.prox = null;
        }

    }



}
