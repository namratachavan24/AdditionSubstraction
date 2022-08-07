using System;
using System.Collections.Generic;
using System.Text;

namespace FirstProject
{
    class Substration
    {
        private int a = 30;
        private int b = 10;
        public int A = 0;
        //parameterless (default constructor)
        public Substration()
        {

        }
        //parameterized constructor
        public Substration(int p, int q)
        {
            p = a;
            q = b;
        }
            //Dont no the return type

            public void SubstrctionOfTwoNumber()
            {

                A = a - b;
            }
    }
}
