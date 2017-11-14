﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetFloatValue.ValueImpedance
{
    class ValueImpedanceNode:Types4OctetFloatValueNode
    {
        public ValueImpedanceNode()
        {
            this.KNXSubNumber = DPST_38;
            this.DPTName = "impedance (Ω)";
        }

        public static TreeNode GetTypeNode()
        {
            ValueImpedanceNode nodeType = new ValueImpedanceNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
