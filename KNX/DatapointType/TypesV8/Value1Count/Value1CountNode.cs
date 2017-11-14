﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypesV8.Value1Count
{
    class Value1CountNode:TypesV8Node
    {
        public Value1CountNode()
        {
            this.KNXSubNumber = DPST_10;
            this.DPTName = "counter pulses (-128..127)";
        }

        public static TreeNode GetTypeNode()
        {
            Value1CountNode nodeType = new Value1CountNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
