using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanbanBoard.UI.WinForm
{
    public partial class frmBoard : Form
    {
        public frmBoard()
        {
            InitializeComponent();
        }

        private void FrmBoard_Load(object sender, EventArgs e)
        {
            this.Text = "Bu board'dan gelecek";
        }
    }
}
