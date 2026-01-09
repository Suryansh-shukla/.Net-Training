using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Transactions;

namespace EventDelegations
{
    interface IBank
    {
        public List<string> GenStatement();
        bool OpenAct(string Details);
    }
    interface RBI
    {

    }
    public class HDFC : IBank
    {
        public delegate void Transaction(int actNo, string date, int amount);
        public event Debit;
        public event Credit;
        public List<string> GenStatement()
        {
            throw new NotImplementedException();
        }


        bool IBank.OpenAct(string Details)
        {
            throw new NotImplementedException();
        }
    }
    class Axis : IBank
    {
        List<string> IBank.GenStatement()
        {
            throw new NotImplementedException();
        }

        bool IBank.OpenAct(string Details)
        {
            throw new NotImplementedException();
        }
    }
    class HDFCJalandhar : HDFC
    {

    }
    class EventDemo
    {
        public static void EventDemoMain()
        {

        }
    }
}
