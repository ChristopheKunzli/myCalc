﻿namespace ModelCalc
{
    public class Maths
    {
        #region private attributes
        private int result;
        #endregion private attributes

        #region public methods
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}