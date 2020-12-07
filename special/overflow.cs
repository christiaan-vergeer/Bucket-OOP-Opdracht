using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht.special
{
    class overflow
    {
        public static void spill(bucket bucket)
        {
            int spill = bucket.Content - bucket.Capacety;
            bucket.Content = bucket.Capacety;
            Console.WriteLine("bucket has overflown, " + spill + " liter has been spilled");
        }
    }
}
