﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypesN8.BlindsControlMode
{
    class BlindsControlModeNode:TypesN8Node
    {
        public BlindsControlModeNode()
        {
            this.KNXSubNumber = DPST_804;
            this.DPTName = "blinds control mode";
        }

        public static TreeNode GetTypeNode()
        {
            BlindsControlModeNode nodeType = new BlindsControlModeNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
