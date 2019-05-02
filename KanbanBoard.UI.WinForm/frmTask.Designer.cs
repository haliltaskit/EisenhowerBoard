namespace KanbanBoard.UI.WinForm
{
    partial class frmTask
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.cmbUrgency = new System.Windows.Forms.ComboBox();
            this.cmbImportance = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(172, 207);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(75, 23);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "Ekle";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Task";
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(60, 22);
            this.txtTask.Multiline = true;
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(184, 70);
            this.txtTask.TabIndex = 0;
            // 
            // cmbUrgency
            // 
            this.cmbUrgency.FormattingEnabled = true;
            this.cmbUrgency.Items.AddRange(new object[] {
            "Urgent",
            "Not Urgent"});
            this.cmbUrgency.Location = new System.Drawing.Point(123, 148);
            this.cmbUrgency.Name = "cmbUrgency";
            this.cmbUrgency.Size = new System.Drawing.Size(121, 21);
            this.cmbUrgency.TabIndex = 2;
            // 
            // cmbImportance
            // 
            this.cmbImportance.FormattingEnabled = true;
            this.cmbImportance.Items.AddRange(new object[] {
            "Important",
            "Not Important"});
            this.cmbImportance.Location = new System.Drawing.Point(123, 107);
            this.cmbImportance.Name = "cmbImportance";
            this.cmbImportance.Size = new System.Drawing.Size(121, 21);
            this.cmbImportance.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Importance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Urgency";
            // 
            // frmTask
            // 
            this.AcceptButton = this.btnAddTask;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 272);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbImportance);
            this.Controls.Add(this.cmbUrgency);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddTask);
            this.Name = "frmTask";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Menu";
            this.Load += new System.EventHandler(this.FrmTask_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.ComboBox cmbUrgency;
        private System.Windows.Forms.ComboBox cmbImportance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}