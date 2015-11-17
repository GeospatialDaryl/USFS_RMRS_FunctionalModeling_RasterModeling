﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ESRI.ArcGIS.esriSystem;

namespace esriUtil.FunctionRasters.NeighborhoodHelper
{
    class aggregationHelperMin : aggregationFunctionDataset
    {
        public override object getTransformedValue(ESRI.ArcGIS.DataSourcesRaster.IPixelBlock3 bigArr, int band, int startClms, int startRws, int cells)
        {
            return blockHelperStats.getBlockMin(bigArr,band, startClms, startRws, cells);
        }

    }
}