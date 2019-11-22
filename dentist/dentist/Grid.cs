using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dentist
{
    public class Grid : DataGridView
    {
        protected override void OnHandleCreated(EventArgs e)
        {
            // Touching the TopLeftHeaderCell here prevents
            // System.InvalidOperationException:
            // This operation cannot be performed while
            // an auto-filled column is being resized.

            var topLeftHeaderCell = TopLeftHeaderCell;

            base.OnHandleCreated(e);
        }

        public Grid()
        {
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToOrderColumns = false;
            EditMode = DataGridViewEditMode.EditOnKeystrokeOrF2;
            MultiSelect = false;
            RowTemplate.Height = 30;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;          
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            DataGridViewCellStyle Alt_style = new DataGridViewCellStyle();
            RowTemplate.Height = 30;
            style.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F);
            ColumnHeadersDefaultCellStyle = style;
            DefaultCellStyle = style;
            Alt_style.BackColor = System.Drawing.Color.FromArgb(254, 178, 73);
            AlternatingRowsDefaultCellStyle = style;          
        }
    }
}
