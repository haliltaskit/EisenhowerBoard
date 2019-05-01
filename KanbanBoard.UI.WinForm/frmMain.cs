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

namespace KanbanBoard.UI.WinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int boardCounter;
        Panel card;
        private void Add_Click(object sender, EventArgs e)
        {

            Panel card = new Panel
            {
                BackColor = Color.FromArgb(28, 144, 160),
                Margin = new Padding(50, 5, 5, 50),
                Name = "card" + boardCounter,
                Size = new Size(125, 100),
            };
            var lblBoardName = new Label
            {
                Text = "Board Name",
                AutoSize = false,
                Margin = new Padding(3, 15, 0, 0),
                Size = new Size(100, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular)
            };
            var lblBoardStatus = new Label
            {
                Text = "Status",
                AutoSize = false,
                Margin = new Padding(3, 15, 0, 0),
                Size = new Size(100, 30),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Font = new Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular)
            };
            var btnOpen = new PictureBox
            {
                AutoSize = false,
                Image = Properties.Resources.icons8_add_white_32,
                Size = new Size(30, 30),
                Name = lblBoardName.Text,
                Location = new Point(45, 60),
            };

            btnOpen.Click += new EventHandler(AddButton_Click);
            pnlflowCanbans.Controls.Add(card);
            card.BringToFront();
            card.Controls.Add(btnOpen);
            card.Controls.Add(lblBoardStatus);
            card.Controls.Add(lblBoardName);
            boardCounter++;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            frmBoard frm = new frmBoard();
            frm.ShowDialog();
        }

    }

}
