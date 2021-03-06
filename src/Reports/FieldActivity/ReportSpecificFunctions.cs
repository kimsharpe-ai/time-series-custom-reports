﻿using System;
using System.Data;
using System.Reflection;
using ReportPluginFramework;
using ReportPluginFramework.ReportData;
using ReportPluginFramework.ReportData.TimeSeriesComputedStatistics;
using ReportPluginFramework.ReportData.TimeSeriesData;
using ReportPluginFramework.ReportData.TimeSeriesDescription;
using System.Collections.Generic;

namespace FieldActivityNamespace
{
    public class ReportSpecificFunctions
    {
        private static ServiceStack.Logging.ILog Log = ServiceStack.Logging.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public static bool TimeRangeOverlaps(DateTimeOffset start, DateTimeOffset? end, DateTimeOffsetInterval interval)
        {
            if (interval.End.HasValue && (start > interval.End.Value)) return false;
            if (interval.Start.HasValue && end.HasValue && (end < interval.Start.Value)) return false;
            return true;
        }
    }
}
