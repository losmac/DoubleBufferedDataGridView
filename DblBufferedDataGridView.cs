//using System.ComponentModel;
//using System.ComponentModel.Design;
using System.Windows.Forms;
//using ComponentFactory.Krypton.Toolkit;

namespace TestDoubleBufferedDataGridView
{
    //[Designer("System.Windows.Forms.Design.ParentControlDesigner, System.Design", typeof(IDesigner))]
    public partial class DblBufferedDataGridView : DataGridView
    {
        public DblBufferedDataGridView()
        {
            InitializeComponent();
            DoubleBuffered = true;
            //this.CellPainting += CustomCellPainting;
        }

        private void CustomCellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //DataGridViewCell dgc = this.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //this.Rows[e.RowIndex].DefaultCellStyle.BackColor = e.RowIndex % 2 == 0 ? Color.White : Color.Ivory;
        }
        
    }
}
