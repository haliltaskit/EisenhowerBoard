using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using KanbanBoard.Model;
using KanbanBoard.BLL;

namespace KanbanBoard.UI.WinForm
{
    public partial class frmMain : Form
    {
        BoardController _boardController;
        TodoTaskController _todoTaskController;
        Board board;
        public frmMain()
        {
            InitializeComponent();
            _boardController = new BoardController();
            _todoTaskController = new TodoTaskController();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            RefreshBoard();
        }
        private void BoardOpen_Click(object sender, EventArgs e)
        {
            var btn= sender as PictureBox;
            frmBoard frm = new frmBoard();
            frm.Text = btn.Text.ToString();
            frm.Tag = btn.Tag;
            frm.ShowDialog();
            RefreshBoard();
        }
        Panel card;
        void RefreshBoard()
        {
            pnlflowCanbans.Controls.Clear();
            foreach (Board item in _boardController.GetBoards())
            {
                card = new Panel
                {
                    BackColor = Color.FromArgb(28, 144, 160),
                    Margin = new Padding(50, 5, 5, 50),
                    Name = item.Name,
                    Size = new Size(125, 100),
                };
                var lblBoardName = new Label
                {
                    Text = item.Name,
                    AutoSize = false,
                    Margin = new Padding(5, 15, 0, 0),
                    Size = new Size(100, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular)
                };
                var lblBoardStatus = new Label
                {
                    Text = string.Format("{0}/{1} Completed", "2", "8"),
                    AutoSize = false,
                    Margin = new Padding(3, 15, 0, 0),
                    Size = new Size(100, 30),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular)
                };
                var btnOpen = new PictureBox
                {
                    AutoSize = false,
                    Image = Properties.Resources.icons8_add_white_32,
                    Size = new Size(30, 30),
                    Tag = item.BoardID,
                    Text = item.Name,
                    Location = new Point(45, 60),
                };
                btnOpen.Click += new EventHandler(BoardOpen_Click);
                pnlflowCanbans.Controls.Add(card);
                card.BringToFront();
                card.Controls.Add(btnOpen);
                card.Controls.Add(lblBoardStatus);
                card.Controls.Add(lblBoardName);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            frmBoardControl frm = new frmBoardControl();
            frm.ShowDialog();
            RefreshBoard();
        }

    }

}
