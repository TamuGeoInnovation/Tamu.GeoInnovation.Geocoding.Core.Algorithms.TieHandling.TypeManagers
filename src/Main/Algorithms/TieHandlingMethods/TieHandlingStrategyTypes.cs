using System;
using System.Data;

namespace USC.GISResearchLab.Geocoding.Core.Algorithms.TieHandlingMethods
{
    [Serializable]
    public class TieHandlingStrategyTypes
    {

        public static DataTable GetAllTieHandlingStrategyTypes()
        {
            DataTable ret = new DataTable();
            ret.Columns.Add(new DataColumn("value", typeof(string)));

            foreach (TieHandlingStrategyType item in Enum.GetValues(typeof(TieHandlingStrategyType)))
            {
                DataRow row = ret.NewRow();
                row["value"] = item.ToString();
                ret.Rows.Add(row);
            }

            return ret;
        }

    }
}
