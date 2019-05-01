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
        public frmTask()
        {
            InitializeComponent();
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTask.Text))
            {
                if (cmbImportance.SelectedIndex > -1 && cmbUrgency.SelectedIndex > -1)
                {
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
