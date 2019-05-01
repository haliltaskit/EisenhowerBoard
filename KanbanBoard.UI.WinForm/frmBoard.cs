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
            //btnAddTask.MouseDown += Lbl_MouseDown;
        }

        private void FrmBoard_Load(object sender, EventArgs e)
        {
            this.Text = "Bu board'dan gelecek";
            //btnAddTask.move
        }

        private void BtnAddTask_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("1");
        }

        private void AddTask(Panel p)
        {
            Label lblTask = new Label
            {
                Text = "Yeni Eklenmiş Task------",
                AutoSize = false,
                Margin = new Padding(3, 10, 0, 0),
                Size = new Size(200, 20),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Dock = DockStyle.Top,
                Font = new Font("Trebuchet MS", 8.25F, FontStyle.Regular)
            };
            lblTask.DoubleClick += LblTask_DoubleClick;
            p.Controls.Add(lblTask);
            
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
            frmTask frm = new frmTask();
            frm.ShowDialog();
            AddTask(pnlFocus);
        }
    }
}
