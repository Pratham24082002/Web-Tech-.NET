using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class VoterException : Exception
    {

        public VoterException(String msg) : base(msg) { 

        }
    }

    internal class Voters
    {
        private int Age;
        private int Balance;

        public Voters(int Age, int Balance) { 
            this.Age = Age;
            this.Balance = Balance;
        }

        public void Validate() { 
            if (this.Age < 18) {
                throw new VoterException("You Are Not Eligible");
            }
        }

    }
}
