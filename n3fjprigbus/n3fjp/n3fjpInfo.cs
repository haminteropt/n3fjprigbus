using HamBusLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace n3fjprigbus.Controllers
{
    public class N3fjpInfo : RigBusInfo
    {
        private static N3fjpInfo instance = null;
        public static N3fjpInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new N3fjpInfo();
                }
                return instance;
            }
        }
    }
}
