﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypesB1.Ramp
{
    class RampNode : TypesB1Node
    {
        public RampNode()
        {
            //this.Text = "1.004 ramp";
            this.KNXSubNumber = DPST_4;
            this.DPTName = "ramp";
        }

        public static TreeNode GetTypeNode()
        {
            RampNode nodeType = new RampNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
