﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Class_WinForms
{
    public class Counter
    {
        int count;

        public Counter(int start)
        {
            count = start;

        }



        public void Increment()
        {
            count++;
        }

        public void Incrementby(int value)
        {

            count += value;

        }


        public void Reset()
        {
            count = 0;
        }


        public int GetValue()
        {
            return count;
        }
    }
}
