using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht
{
    class FillbyBucket
    {
        public static void Fill(bucket bucket1, bucket bucket2)
        {
            bucket1.Content = bucket1.Content + bucket2.Content;
            bucket2.Content = 0;
            Console.WriteLine("bucket 2 has been emptied in bucket 1");
            if (bucket1.Content > bucket1.Capacety)
            {
                special.overflow.spill(bucket1);
            }
        }
    }
}
