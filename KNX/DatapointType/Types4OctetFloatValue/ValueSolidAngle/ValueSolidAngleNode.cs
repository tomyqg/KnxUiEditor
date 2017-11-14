﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetFloatValue.ValueSolidAngle
{
    class ValueSolidAngleNode:Types4OctetFloatValueNode
    {
        public ValueSolidAngleNode()
        {
            this.KNXSubNumber = DPST_63;
            this.DPTName = "solid angle (sr)";
        }

        public static TreeNode GetTypeNode()
        {
            ValueSolidAngleNode nodeType = new ValueSolidAngleNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
