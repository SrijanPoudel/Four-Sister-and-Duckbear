using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace The_Four_Sisters_and_the_Duckbear
{
    public class FourSisterandDuckbear
    {
        private int eggs = 0;




        public int Eggs
        {
            get { return this.eggs; }
            set
            {
                if (value > 0)
                {
                    this.eggs = value;
                }
                else
                {
                    this.eggs = 0;
                }
            }
        }
        public int EqualDivided
        {
            get { return this.eggs / 4; }
        }
        public int RemainingDivided
        {
            get { return this.eggs % 4; }
        }

        public string GetResultMessage()
        {
            int equalshare = EqualDivided;
            int leftover = RemainingDivided;

            if (leftover == 0)
            {
                return ($"There are no leftover eggs. Each sister will get {equalshare} eggs.");
            }
            else
            {
                return ($"If there are {eggs} eggs, each sister gets {equalshare} eggs, and there are {leftover} leftover eggs.");
            }
        }
    }
}