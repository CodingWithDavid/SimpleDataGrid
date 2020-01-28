
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
    }
}
