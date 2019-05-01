namespace KanbanBoard.UI.WinForm
{
    partial class frmMain
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
            this.pnlflowCanbans = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlflowCanbans
            // 
            this.pnlflowCanbans.AutoScroll = true;
            this.pnlflowCanbans.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlflowCanbans.Location = new System.Drawing.Point(0, 131);
            this.pnlflowCanbans.Name = "pnlflowCanbans";
            this.pnlflowCanbans.Size = new System.Drawing.Size(800, 480);
            this.pnlflowCanbans.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(12, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // list
            // 
            this.list.Image = global::KanbanBoard.UI.WinForm.Properties.Resources.icons8_list_32;
            this.list.Location = new System.Drawing.Point(736, 73);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(32, 32);
            this.list.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.list.TabIndex = 1;
            this.list.TabStop = false;
            // 
            // picAdd
            // 
            this.picAdd.Image = global::KanbanBoard.UI.WinForm.Properties.Resources.icons8_add_32;
            this.picAdd.Location = new System.Drawing.Point(698, 73);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(32, 32);
            this.picAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAdd.TabIndex = 0;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.pnlflowCanbans);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban Board";
            ((System.ComponentModel.ISupportInitialize)(this.list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlflowCanbans;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox list;
        private System.Windows.Forms.Label label1;
    }
}

