﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoQDemo
{
    class Program : IDisposable
    {
        static void Main(string[] args)
        {
            var mock = new Mock<IUSD_CLP_ExchangeRateFeed>();
            mock.Setup(lm => lm.GetActualUSDValue()).Returns(500);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

    public interface ICalculator
    {
        int Add(int param1, int param2);
        int Subtract(int param1, int param2);
        int Multipy(int param1, int param2);
        int Divide(int param1, int param2);
        int ConvertUSDtoCLP(int unit);
    }

    public interface IUSD_CLP_ExchangeRateFeed
    {
        int GetActualUSDValue();
    }

    public class Calculator : ICalculator
    {
        private IUSD_CLP_ExchangeRateFeed _feed;
        public Calculator(IUSD_CLP_ExchangeRateFeed feed)
        {
            this._feed = feed;
        }
        #region ICalculator Members
        public int Add(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Subtract(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Multipy(int param1, int param2)
        {
            throw new NotImplementedException();
        }
        public int Divide(int param1, int param2)
        {
            return param1 / param2;
        }
        public int ConvertUSDtoCLP(int unit)
        {
            return unit * this._feed.GetActualUSDValue();
        }
        #endregion
    }

}
