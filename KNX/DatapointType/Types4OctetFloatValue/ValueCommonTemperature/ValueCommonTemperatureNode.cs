﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.Types4OctetFloatValue.ValueCommonTemperature
{
    class ValueCommonTemperatureNode:Types4OctetFloatValueNode
    {
        public ValueCommonTemperatureNode()
        {
            this.KNXSubNumber = DPST_68;
            this.DPTName = "temperature (°C)";
        }

        public static TreeNode GetTypeNode()
        {
            ValueCommonTemperatureNode nodeType = new ValueCommonTemperatureNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
