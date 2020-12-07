using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht
{
    class fillPartial
    {
        public static void fill(int amount, bucket bucket)
        {
            bucket.Content = bucket.Content + amount;
            Console.WriteLine("bucket has been filled with " + amount);
            if (bucket.Content > bucket.Capacety)
            {
                special.overflow.spill(bucket);
            }
        }
    }
}
