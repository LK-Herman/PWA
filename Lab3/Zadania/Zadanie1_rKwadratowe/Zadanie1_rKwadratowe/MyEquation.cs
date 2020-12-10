using System;
using System.Collections.Generic;
using System.Text;

namespace Zadanie1_rKwadratowe
{
    class MyEquation
    {
        private double a,b,c, delta;
        private double[] pX = new double[3]; //[0] - flaga; [1] - pierwiastek 1; [2] - pierwiastek 2;
        public MyEquation(double a1, double b1, double c1)
        {
            this.a = a1;
            this.b = b1;
            this.c = c1;
            this.delta = (b1 * b1) - (4 * a1 * c1);
        }
        public int checkDelta()
        {
            if (a == 0) return 3;
            if (delta == 0) return 1;
            if (delta > 0) return 2;
            //(delta < 0)  
            return 0;
        }
        public void findX(int deltaFlag)
        {
            switch (deltaFlag)
            {
                case 1:
                    {
                        pX[0] = 1; //flaga
                        pX[1] = ((-1) * b) / (2 * a);
                        pX[2] = 0;
                        break;
                    }
                case 2:
                    {
                        pX[0] = 2; //flaga
                        pX[1] = ((-1) * b - Math.Sqrt(delta)) / (2 * a);
                        pX[2] = ((-1) * b + Math.Sqrt(delta)) / (2 * a);
                        break;
                    }
                case 3:
                    {
                        pX[0] = 3; //flaga
                        break;
                    }
                default:
                    pX[0] = 0; //flaga
                    pX[1] = 0;
                    pX[2] = 0;
                    break;
            }
        }
        public double GetFlag()
        {
            return pX[0];
        }
        public double GetX1()
        {
            return pX[1];
        }
        public double GetX2()
        {
            return pX[2];
        }
    }
}
