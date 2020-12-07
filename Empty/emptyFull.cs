using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht
{
    class emptyFull
    {
        public static void Empty(bucket bucket)
        {
            bucket.Content = 0;
            Console.WriteLine("bucket has been emptied");
        }
    }
}
