using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Transaction
    {
        public string _Comment;
        public string _NumberAccount;
        public Transaction(string Comment, string NumberAccount) 
        {
            _Comment = Comment;
            _NumberAccount = NumberAccount;
        }
        


    }
}
