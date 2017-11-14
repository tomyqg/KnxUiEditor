﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetSignedValue.Value4Count
{
    class Value4CountNode:Types4OctetSignedValueNode
    {
        public Value4CountNode()
        {
            this.KNXSubNumber = DPST_1;
            this.DPTName = "counter pulses (signed)";
        }

        public static TreeNode GetTypeNode()
        {
            Value4CountNode nodeType = new Value4CountNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
