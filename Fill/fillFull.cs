using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht
{
    static class fillFull
    {
        public static void Full(bucket bucket)
        {
            bucket.Content = bucket.Capacety;
            Console.WriteLine("bucket has been filled");
        }
    }
}
