namespace KanbanBoard.UI.WinForm
{
    partial class frmBoard
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
            this.pnlFocus = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSchedule = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDelegate = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlEliminate = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddTask)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFocus
            // 
            this.pnlFocus.AllowDrop = true;
            this.pnlFocus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.pnlFocus.Location = new System.Drawing.Point(50, 50);
            this.pnlFocus.Name = "pnlFocus";
            this.pnlFocus.Size = new System.Drawing.Size(250, 250);
            this.pnlFocus.TabIndex = 0;
            this.pnlFocus.DragDrop += new System.Windows.Forms.DragEventHandler(this.Pnl_DragDrop);
            this.pnlFocus.DragOver += new System.Windows.Forms.DragEventHandler(this.pnl_DragOver);
            // 
            // pnlSchedule
            // 
            this.pnlSchedule.AllowDrop = true;
            this.pnlSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(213)))));
            this.pnlSchedule.Location = new System.Drawing.Point(350, 50);
            this.pnlSchedule.Name = "pnlSchedule";
            this.pnlSchedule.Size = new System.Drawing.Size(250, 250);
            this.pnlSchedule.TabIndex = 0;
            this.pnlSchedule.DragDrop += new System.Windows.Forms.DragEventHandler(this.Pnl_DragDrop);
            this.pnlSchedule.DragOver += new System.Windows.Forms.DragEventHandler(this.pnl_DragOver);
            // 
            // pnlDelegate
            // 
            this.pnlDelegate.AllowDrop = true;
            this.pnlDelegate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(28)))));
            this.pnlDelegate.Location = new System.Drawing.Point(50, 350);
            this.pnlDelegate.Name = "pnlDelegate";
            this.pnlDelegate.Size = new System.Drawing.Size(250, 250);
            this.pnlDelegate.TabIndex = 1;
            this.pnlDelegate.DragDrop += new System.Windows.Forms.DragEventHandler(this.Pnl_DragDrop);
            this.pnlDelegate.DragOver += new System.Windows.Forms.DragEventHandler(this.pnl_DragOver);
            // 
            // pnlEliminate
            // 
            this.pnlEliminate.AllowDrop = true;
            this.pnlEliminate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.pnlEliminate.Location = new System.Drawing.Point(350, 350);
            this.pnlEliminate.Name = "pnlEliminate";
            this.pnlEliminate.Size = new System.Drawing.Size(250, 250);
            this.pnlEliminate.TabIndex = 2;
            this.pnlEliminate.DragDrop += new System.Windows.Forms.DragEventHandler(this.Pnl_DragDrop);
            this.pnlEliminate.DragOver += new System.Windows.Forms.DragEventHandler(this.pnl_DragOver);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(120, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "ᴜʀɢᴇɴᴛ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(401, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "ɴᴏᴛ ᴜʀɢᴇɴᴛ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(315, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 250);
            this.label3.TabIndex = 5;
            this.label3.Text = "ɪᴍᴘᴏʀᴛᴀɴᴛ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(144)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(315, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 250);
            this.label4.TabIndex = 6;
            this.label4.Text = "ɴᴏᴛ ɪᴍᴘᴏʀᴛᴀɴᴛ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddTask
            // 
            this.btnAddTask.Image = global::KanbanBoard.UI.WinForm.Properties.Resources.icons8_add_32;
            this.btnAddTask.Location = new System.Drawing.Point(310, 309);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(30, 30);
            this.btnAddTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAddTask.TabIndex = 7;
            this.btnAddTask.TabStop = false;
            this.btnAddTask.Click += new System.EventHandler(this.BtnAddTask_Click);
            // 
            // frmBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 677);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlEliminate);
            this.Controls.Add(this.pnlDelegate);
            this.Controls.Add(this.pnlSchedule);
            this.Controls.Add(this.pnlFocus);
            this.Name = "frmBoard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddTask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlFocus;
        private System.Windows.Forms.FlowLayoutPanel pnlSchedule;
        private System.Windows.Forms.FlowLayoutPanel pnlDelegate;
        private System.Windows.Forms.FlowLayoutPanel pnlEliminate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnAddTask;
    }
}