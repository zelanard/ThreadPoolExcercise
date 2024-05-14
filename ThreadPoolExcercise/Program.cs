using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadPoolExcercise.Excersizes.ThreadPoolMushrooms;

//As you said that we can wait with turning in this project until tomorrow, I have not yet given this a proper go, as I was expecting to do that tomorrow.
//I can however see that you've set it to be turned in today, so I am making the git project and I'm turning it in.
//If this is the text you see, I appologize for the confusoin. The code will be here soon.
//note that I have made excersize 1 and 2.

namespace ThreadPoolExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mushroom mush = new Mushroom();
            mush.Spore(5);
        }
    }
}