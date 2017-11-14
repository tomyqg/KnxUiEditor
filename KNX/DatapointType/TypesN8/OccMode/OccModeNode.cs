﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypesN8.OccMode
{
    class OccModeNode:TypesN8Node
    {
        public OccModeNode()
        {
            this.KNXSubNumber = DPST_3;
            this.DPTName = "occupied";
        }

        public static TreeNode GetTypeNode()
        {
            OccModeNode nodeType = new OccModeNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
