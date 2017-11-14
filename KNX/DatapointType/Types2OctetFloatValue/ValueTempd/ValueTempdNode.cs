﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types2OctetFloatValue.ValueTempd
{
    class ValueTempdNode:Types2OctetFloatValueNode
    {
        public ValueTempdNode()
        {
            this.KNXSubNumber = DPST_2;
            this.DPTName = "temperature difference (K)";
        }

        public static TreeNode GetTypeNode()
        {
            ValueTempdNode nodeType = new ValueTempdNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
