﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetFloatValue.ValuePhaseAngleDeg
{
    class ValuePhaseAngleDegNode:Types4OctetFloatValueNode
    {
        public ValuePhaseAngleDegNode()
        {
            this.KNXSubNumber = DPST_55;
            this.DPTName = "phase angle (°)";
        }

        public static TreeNode GetTypeNode()
        {
            ValuePhaseAngleDegNode nodeType = new ValuePhaseAngleDegNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
