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
    public partial class frmBoard : Form
    {
        TodoTask task;
        BoardController _boardController;
        TodoTaskController _todoTaskController;
        public frmBoard()
        {
            InitializeComponent();
            _boardController = new BoardController();
            _todoTaskController = new TodoTaskController();

            //btnAddTask.MouseDown += Lbl_MouseDown;
        }

        private void FrmBoard_Load(object sender, EventArgs e)
        {
            btnAddTask.Tag = Tag;
            FillTask();
        }

        private void BtnAddTask_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void FillTask()
        {
            foreach (Control item in Controls)
            {
                if (item is Panel)
                {
                    item.Controls.Clear();
                }
            }
            foreach (var item in _todoTaskController.GetListByBoard((Guid)Tag))
            {
                Label lblTask = new Label
                {
                    Text = item.Name,
                    AutoSize = false,
                    Tag = item.TaskID,
                    Name = "lbl",
                    Margin = new Padding(3, 10, 0, 0),
                    Size = new Size(200, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.White,
                    Dock = DockStyle.Top,
                    Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular)
                };
                if (item.Importance)
                {
                    if (item.Urgency)
                    {
                        pnlFocus.Controls.Add(lblTask);
                    }
                    else
                    {
                        pnlSchedule.Controls.Add(lblTask);
                    }
                }
                else
                {
                    if (item.Urgency)
                    {
                        pnlDelegate.Controls.Add(lblTask);
                    }
                    else
                    {
                        pnlEliminate.Controls.Add(lblTask);
                    }
                }
                lblTask.DoubleClick += LblTask_DoubleClick;
            }
        }

        private void LblTask_DoubleClick(object sender, EventArgs e)
        {
            frmTaskControl frm = new frmTaskControl();
            frm.ShowDialog();
        }

        //private void Lbl_MouseDown(object sender, MouseEventArgs e)
        //{
        //    Label lbl = sender as Label;
        //    lbl.DoDragDrop(sender, DragDropEffects.Move);
        //}


        private void Pnl_DragDrop(object sender, DragEventArgs e)
        {
            Label lbl = e.Data.GetData(typeof(Label)) as Label;
            Panel pnl = sender as Panel;

            lbl.Parent.Controls.Remove(lbl);
            pnl.Controls.Add(lbl);
        }

        private void pnl_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            var btn = sender as PictureBox;
            frmTask frm = new frmTask();
            frm.Tag = Tag;
            frm.ShowDialog();
            FillTask();
        }
    }
}
