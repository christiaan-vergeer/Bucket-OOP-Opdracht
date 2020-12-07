using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht.models
{
    public class RainBucket : bucket
    {
        public RainBucket(string size)
        {
            if(size.Equals("small"))
            {
                this.Capacety = 80;
            }
            else if(size.Equals("medium"))
            {
                this.Capacety = 120;
            }
            else
            {
                this.Capacety = 160;
            }            
        }
    }

}
