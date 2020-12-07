using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht.Creating
{
    class addingrainbucket
    {
        public static void addrainbucket(List<models.RainBucket> buckets, string size)
        {
            buckets.Add(new models.RainBucket(size));
        }
    }
}
