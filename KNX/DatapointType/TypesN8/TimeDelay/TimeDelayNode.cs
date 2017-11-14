﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypesN8.TimeDelay
{
    class TimeDelayNode:TypesN8Node
    {
        public TimeDelayNode()
        {
            this.KNXSubNumber = DPST_13;
            this.DPTName = "time delay";
        }

        public static TreeNode GetTypeNode()
        {
            TimeDelayNode nodeType = new TimeDelayNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
