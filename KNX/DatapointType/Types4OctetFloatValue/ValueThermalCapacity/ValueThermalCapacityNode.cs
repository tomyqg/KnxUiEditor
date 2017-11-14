﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetFloatValue.ValueThermalCapacity
{
    class ValueThermalCapacityNode:Types4OctetFloatValueNode
    {
        public ValueThermalCapacityNode()
        {
            this.KNXSubNumber = DPST_71;
            this.DPTName = "thermal capacity (J/K)";
        }

        public static TreeNode GetTypeNode()
        {
            ValueThermalCapacityNode nodeType = new ValueThermalCapacityNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
