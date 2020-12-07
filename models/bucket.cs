using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht
{
    public delegate void notify();

    public class bucket
    {
        public event notify test;
        public int Content;
        public int Capacety;

        public bucket(int Content, int Capacety)
        {
            this.Content = Content;
            this.Capacety = Capacety;
        }

        public bucket(int Capacetey) : this(0, Capacetey) 
        {

        }

        public bucket() : this(0, 12)
        {

        }

        public void Fill(int ammount)
        {
            Content += ammount;
            if(Content > Capacety)
            {
                int spilled = Content - Capacety;
                Content = Capacety;
                overflowing();
            }
        }

        public void Fill(bucket bucket)
        {
            Content += bucket.Content;
            bucket.Content = 0;
        }



        protected virtual void overflowing()
        {
            test.Invoke();
        }

    }

}
