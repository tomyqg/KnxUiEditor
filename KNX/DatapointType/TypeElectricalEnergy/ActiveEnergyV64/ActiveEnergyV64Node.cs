﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KNX.DatapointType.TypeElectricalEnergy.ActiveEnergyV64
{
    class ActiveEnergyV64Node:TypeElectricalEnergyNode
    {
        public ActiveEnergyV64Node()
        {
            this.KNXSubNumber = DPST_10;
            this.DPTName = "active energy (Wh)";
        }

        public static TreeNode GetTypeNode()
        {
            ActiveEnergyV64Node nodeType = new ActiveEnergyV64Node();
            nodeType.Text = nodeType.KNXMainNumber + "." + nodeType.KNXSubNumber + " " + nodeType.DPTName;

            return nodeType;
        }
    }
}
