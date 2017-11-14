﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types2OctetFloatValue.ValueTempF
{
    class ValueTempFNode:Types2OctetFloatValueNode
    {
        public ValueTempFNode(){
            this.KNXSubNumber = DPST_27;
            this.DPTName = "temperature (°F)";
        }

        public static TreeNode GetTypeNode()
        {
            ValueTempFNode nodeType = new ValueTempFNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
