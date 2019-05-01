using KanbanBoard.BLL;
using KanbanBoard.Model;
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
        BoardController _boardController;
        Board board;
        public frmBoardControl()
        {
            InitializeComponent();
            _boardController = new BoardController();
            board = new Board();
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtBoard.Text))
            {
                board.Name = (txtBoard.Text).Trim();
                _boardController.Add(board);
                this.Close();
            }
            else
            {
                MessageBox.Show("Eklenemedi");
            }
        }
    }
}
