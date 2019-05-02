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
        TodoTaskController _todoTaskController;
        public frmBoard()
        {
            InitializeComponent();
            _todoTaskController = new TodoTaskController();
        }

        private void FrmBoard_Load(object sender, EventArgs e)
        {
            FillTask();
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
                lblTask.MouseDown += LblTask_Click;
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
            }
        }

        private void LblTask_Click(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            if (e.Button != MouseButtons.Right)
            {
                lbl.DoDragDrop(sender, DragDropEffects.Move);
            }
            else
            {
                frmTaskControl frm = new frmTaskControl();
                frm.Tag = lbl.Tag;
                frm.ShowDialog();
            }
        }

        private void Pnl_DragDrop(object sender, DragEventArgs e)
        {
            Label lbl = e.Data.GetData(typeof(Label)) as Label;
            Panel pnl = sender as Panel;
            task = new TodoTask();
            task = _todoTaskController.GetTask((Guid)lbl.Tag);
            ChangeStatus(pnl);
            _todoTaskController.Update(task);
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

        private void ChangeStatus(Panel p)
        {
            switch (p.Name)
            {
                case "pnlFocus":
                    task.Importance = true;
                    task.Urgency = true;
                    break;
                case "pnlSchedule":
                    task.Importance = true;
                    task.Urgency = false;
                    break;
                case "pnlDelegate":
                    task.Importance = false;
                    task.Urgency = true;
                    break;
                case "pnlTerminate":
                    task.Importance = false;
                    task.Urgency = false;
                    break;
                default:
                    break;
            }
        }
    }
}
