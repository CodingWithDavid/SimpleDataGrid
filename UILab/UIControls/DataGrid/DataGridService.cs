
using System;

namespace UILab.UIControls.DataGrid
{
    public class DataGridService
    {
        public static string GetSortStyle(int index, int sortIndex, bool sortDirection)
        {
            string result = string.Empty;
            if (index == sortIndex)
            {
                if (sortDirection)
                {
                    result = "fa-sort-up";
                }
                else
                {
                    result = "fa-sort-down";
                }
            }
            return result;
        }

        public static int GetPageCount(int pageSize, int recordCount)
        {
            int result = 0;
            if(pageSize > 0)
            {
                result = recordCount / pageSize;
                int remainer = recordCount % pageSize;
                if(remainer > 0)
                {
                    result++;
                }
            }
            return result;
        }
    }
}
