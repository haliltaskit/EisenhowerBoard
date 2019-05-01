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
    public partial class frmBoardControl : Form
    {
        public frmBoardControl()
        {
            InitializeComponent();
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoard.Text))
            {
                this.Close();
            }
        }
    }
}
