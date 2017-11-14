﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypesV8.StatusMode1
{
    class StatusMode3Node:TypesV8Node
    {
        public StatusMode3Node()
        {
            this.KNXSubNumber = DPST_20;
            this.DPTName = "status with mode";
        }

        public static TreeNode GetTypeNode()
        {
            StatusMode3Node nodeType = new StatusMode3Node();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
