﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypesB1.DimSendStyle
{
    class DimSendStyleNode : TypesB1Node
    {
        public DimSendStyleNode()
        {
            //this.Text = "1.013 dim send style";
            this.KNXSubNumber = DPST_13;
            this.DPTName = "dim send style";
        }

        public static TreeNode GetTypeNode()
        {
            DimSendStyleNode nodeType = new DimSendStyleNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
