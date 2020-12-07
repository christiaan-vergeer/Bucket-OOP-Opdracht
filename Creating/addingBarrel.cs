using System;
using System.Collections.Generic;
using System.Text;

namespace Bucket_OOP_Opdracht.Creating
{
    class addingBarrel
    {
        public static void addBerral(List<models.oilbarrel> barrel)
        {
            barrel.Add(new models.oilbarrel { Content = 0});
        }
    }
}
