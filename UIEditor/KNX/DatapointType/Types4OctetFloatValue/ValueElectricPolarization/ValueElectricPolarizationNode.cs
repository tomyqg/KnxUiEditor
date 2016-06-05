﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIEditor.KNX.DatapointType.Types4OctetFloatValue.ValueElectricPolarization
{
    class ValueElectricPolarizationNode:Types4OctetFloatValueNode
    {
        public ValueElectricPolarizationNode(){
            this.KNXSubNumber = DPST_26;
            this.Name = "electric polarization (C/m²)";
        }

        public static TreeNode GetTypeNode()
        {
            ValueElectricPolarizationNode nodeType = new ValueElectricPolarizationNode();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.Name;

            return nodeType;
        }
    }
}