using System;
using System.Collections.Generic;

namespace Bucket_OOP_Opdracht
{
    public class Program
    {
        static void Main(string[] args)
        {
            bucket bl = new bucket();
            bl.test += trigger; 


            var buckets = new List<bucket>();
            int Capacity = 12;
            Creating.addingBucket.addbucket(buckets, Capacity);
            Creating.addingBucket.addbucket(buckets, Capacity);
            fillFull.Full(buckets[0]);
            Console.WriteLine("bucket 1's content = " + buckets[0].Content);
            fillPartial.fill(6, buckets[1]);
            Console.WriteLine("bucket 2's content = " + buckets[1].Content);
            emptyFull.Empty(buckets[0]);
            Console.WriteLine("bucket 1's content = " + buckets[0].Content);
            EmptyPartially.Empty(buckets[1], 4);
            Console.WriteLine("bucket 2's content = " + buckets[1].Content);
            FillbyBucket.Fill(buckets[0], buckets[1]);
            Console.WriteLine("buckets 1's content = " + buckets[0].Content );
            Console.WriteLine("buckets 2's content = " + buckets[1].Content);

            Console.WriteLine("");
            var barrels = new List<models.oilbarrel>();
            Creating.addingBarrel.addBerral(barrels);
            Console.WriteLine("barrel 1's content = " + barrels[0].Content);

            Console.WriteLine("");
            var rainbuckets = new List<models.RainBucket>();
            string small = "small";
            string medium = "medium";
            string large = "large";
            Creating.addingrainbucket.addrainbucket(rainbuckets, small);
            Creating.addingrainbucket.addrainbucket(rainbuckets, medium);
            Creating.addingrainbucket.addrainbucket(rainbuckets, large);
            Console.WriteLine("rainbucket 1's size = " + rainbuckets[0].Capacety);
            Console.WriteLine("rainbucket 2's size = " + rainbuckets[1].Capacety);
            Console.WriteLine("rainbucket 3's zise = " + rainbuckets[2].Capacety);

            Console.WriteLine("");
            fillFull.Full(buckets[0]);
            fillPartial.fill(3, buckets[0]);
        }

        public static void trigger()
        {
            Console.WriteLine("overflowed");
        }
    }

}
