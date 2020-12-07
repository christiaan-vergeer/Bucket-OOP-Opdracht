using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht.models
{
    public class oilbarrel : bucket
    {
        public oilbarrel(int Content, int Capacety)
        {
            this.Content = Content;
            this.Capacety = Capacety;
        }

        public oilbarrel() : this(0, 159)
        {

        }
    }
}
