﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetSignedValue.FlowRatem3h
{
    class FlowRatem3hNode:Types4OctetSignedValueNode
    {
        public FlowRatem3hNode()
        {
            this.KNXSubNumber = DPST_2;
            this.DPTName = "flow rate (m³/h)";
        }

        public static TreeNode GetTypeNode()
        {
            FlowRatem3hNode nodeType = new FlowRatem3hNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
