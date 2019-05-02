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
    public partial class frmTask : Form
    {
        TodoTask task;
        TodoTaskController _todoTaskController;
        public frmTask()
        {
            InitializeComponent();
            _todoTaskController = new TodoTaskController();
            task = new TodoTask();
        }
        private void FrmTask_Load(object sender, EventArgs e)
        {
            task.BoardID = (Guid)Tag;
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            int importanceIndex = cmbImportance.SelectedIndex;
            int urgencyIndex = cmbUrgency.SelectedIndex;
            if (!String.IsNullOrWhiteSpace(txtTask.Text))
            {
                if (importanceIndex > -1 && urgencyIndex > -1)
                {
                    task.Name = (txtTask.Text).Trim();
                    switch (importanceIndex)
                    {
                        case 0:
                            task.Importance = true;
                            break;
                        case 1:
                            task.Importance = false;
                            break;
                        default:
                            break;
                    }
                    switch (urgencyIndex)
                    {
                        case 0:
                            task.Urgency = true;
                            break;
                        case 1:
                            task.Urgency = false;
                            break;
                        default:
                            break;
                    }
                    _todoTaskController.Add(task);
                    MessageBox.Show("Ekleme Başarılı");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lütfen önem ve aciliyet durumunu güncelleyiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir görev ekleyiniz");
            }
        }

    }
}
