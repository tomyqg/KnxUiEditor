﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetFloatValue.ValueElectricFieldStrength
{
    class ValueElectricFieldStrengthNode : Types4OctetFloatValueNode
    {
        public ValueElectricFieldStrengthNode()
        {
            this.KNXSubNumber = DPST_23;
            this.DPTName = "electric field strength (V/m)";
        }

        public static TreeNode GetTypeNode()
        {
            ValueElectricFieldStrengthNode nodeType = new ValueElectricFieldStrengthNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
