﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypeB8.StatusGen
{
    class StatusGenNode:TypeB8Node
    {
        public StatusGenNode()
        {
            this.KNXSubNumber = DPST_1;
            this.DPTName = "general status";
        }

        public static TreeNode GetTypeNode()
        {
            StatusGenNode nodeType = new StatusGenNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
