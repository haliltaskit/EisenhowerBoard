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
    public partial class frmTaskControl : Form
    {
        TodoTask task;
        BoardController _boardController;
        TodoTaskController _todoTaskController;
        public frmTaskControl()
        {
            InitializeComponent();
            _boardController = new BoardController();
            _todoTaskController = new TodoTaskController();
        }

        private void FrmTaskControl_Load(object sender, EventArgs e)
        {
            task = new TodoTask();
            task=_todoTaskController.GetTask((Guid)Tag);
            txtTask.Text = (task.Name).Trim();
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            task.IsFinished = true;
            _todoTaskController.Update(task);
            MessageBox.Show("Görev tamamlandı");
            this.Close();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            task.Name = txtTask.Text;
            _todoTaskController.Update(task);
            MessageBox.Show("Güncelleme işlemi tamamlandı");
            this.Close();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            task.IsDeleted = true;
            _todoTaskController.Update(task);
            MessageBox.Show("Silme işlemi tamamlandı");
            this.Close();
        }
    }
}
