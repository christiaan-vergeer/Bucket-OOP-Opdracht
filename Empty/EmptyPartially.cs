using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht
{
    class EmptyPartially
    {
        public static void Empty(bucket bucket, int ammount)
        {
            bucket.Content = bucket.Content - ammount;
            Console.WriteLine("bucket has been drained by " + ammount);
        }
    }
}
