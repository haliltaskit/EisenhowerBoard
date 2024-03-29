﻿namespace KanbanBoard.UI.WinForm
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
            this.btnList = new System.Windows.Forms.PictureBox();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnList)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(14, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Board List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnList
            // 
            this.btnList.Image = global::KanbanBoard.UI.WinForm.Properties.Resources.icons8_list_32;
            this.btnList.Location = new System.Drawing.Point(736, 73);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(32, 32);
            this.btnList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnList.TabIndex = 1;
            this.btnList.TabStop = false;
            this.btnList.Click += new System.EventHandler(this.BtnList_Click);
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
            this.picAdd.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to Eisenhower Board";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 611);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.pnlflowCanbans);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kanban Board";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlflowCanbans;
        private System.Windows.Forms.PictureBox picAdd;
        private System.Windows.Forms.PictureBox btnList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

