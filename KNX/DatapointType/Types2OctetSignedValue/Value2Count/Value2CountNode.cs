﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types2OctetSignedValue.Value2Count
{
    class Value2CountNode:Types2OctetSignedValueNode
    {
        public Value2CountNode()
        {
            this.KNXSubNumber = DPST_1;
            this.DPTName = "pulses difference";
        }

        public static TreeNode GetTypeNode()
        {
            Value2CountNode nodeType = new Value2CountNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
