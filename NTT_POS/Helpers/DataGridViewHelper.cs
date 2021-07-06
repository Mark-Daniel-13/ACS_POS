using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTT_POS.Helpers
{
    public class DataGridViewHelper
    {
        public static void Search(string searchText, System.Windows.Forms.DataGridView dgv)
        {
            string searchValue = searchText.ToUpper();
            dgv.ClearSelection();
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (!string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToUpper().Contains(searchValue))
                        {
                            int rowIndex = row.Index;
                            dgv.Rows[rowIndex].Selected = true;
                            return;
                        }
                    }
                }
            }
        }

        public static void Search(string searchText, System.Windows.Forms.DataGridView dgv, string disableColumnName)
        {
            string searchValue = searchText.ToUpper();
            dgv.ClearSelection();
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (!string.IsNullOrEmpty(searchValue))
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].OwningColumn.HeaderText != disableColumnName)
                        {
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToUpper().Contains(searchValue))
                            {
                                int rowIndex = row.Index;
                                dgv.Rows[rowIndex].Selected = true;
                                return;
                            }
                        }
                    }
                }
            }
        }

        public static void ClearDatagrid(System.Windows.Forms.DataGridView dgv)
        {
            if (dgv.DataSource != null)
            {
                dgv.DataSource = null;
            }
            else
            {
                dgv.Rows.Clear();
            }
        }

        public static void ChangeDateFormat(System.Windows.Forms.DataGridView dgv, int index, string format="MM/dd/yyyy") {
            
            dgv.Columns[index+3].DefaultCellStyle.Format = format;
        }
    }
}
