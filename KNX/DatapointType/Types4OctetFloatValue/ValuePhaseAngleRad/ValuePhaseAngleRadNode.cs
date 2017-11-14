﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetFloatValue.ValuePhaseAngleRad
{
    class ValuePhaseAngleRadNode:Types4OctetFloatValueNode
    {
        public ValuePhaseAngleRadNode()
        {
            this.KNXSubNumber = DPST_54;
            this.DPTName = "phase angle (rad)";
        }

        public static TreeNode GetTypeNode()
        {
            ValuePhaseAngleRadNode nodeType = new ValuePhaseAngleRadNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
