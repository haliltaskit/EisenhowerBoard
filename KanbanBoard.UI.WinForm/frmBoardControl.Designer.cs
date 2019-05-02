namespace KanbanBoard.UI.WinForm
{
    partial class frmBoardControl
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
            this.txtBoard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoard
            // 
            this.txtBoard.Location = new System.Drawing.Point(91, 27);
            this.txtBoard.Multiline = true;
            this.txtBoard.Name = "txtBoard";
            this.txtBoard.Size = new System.Drawing.Size(184, 31);
            this.txtBoard.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Board Name";
            // 
            // btnAddBoard
            // 
            this.btnAddBoard.Location = new System.Drawing.Point(200, 104);
            this.btnAddBoard.Name = "btnAddBoard";
            this.btnAddBoard.Size = new System.Drawing.Size(75, 23);
            this.btnAddBoard.TabIndex = 1;
            this.btnAddBoard.Text = "Ekle";
            this.btnAddBoard.UseVisualStyleBackColor = true;
            this.btnAddBoard.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // frmBoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 156);
            this.Controls.Add(this.txtBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddBoard);
            this.Name = "frmBoardControl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Board";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddBoard;
    }
}