﻿namespace WindowsGuiClient
{
    partial class FileManager
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.selectMyDrives = new System.Windows.Forms.ComboBox();
            this.listLocal = new System.Windows.Forms.ListView();
            this.icon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button4 = new System.Windows.Forms.Button();
            this.btnCopyToRemote = new System.Windows.Forms.Button();
            this.selectRemoteDrives = new System.Windows.Forms.ComboBox();
            this.listRemote = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.btnCopyFromRemote = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Location = new System.Drawing.Point(0, 354);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusStrip1.Size = new System.Drawing.Size(676, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.selectMyDrives);
            this.splitContainer1.Panel1.Controls.Add(this.listLocal);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.btnCopyToRemote);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.selectRemoteDrives);
            this.splitContainer1.Panel2.Controls.Add(this.listRemote);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.btnCopyFromRemote);
            this.splitContainer1.Size = new System.Drawing.Size(676, 354);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // selectMyDrives
            // 
            this.selectMyDrives.FormattingEnabled = true;
            this.selectMyDrives.Location = new System.Drawing.Point(3, 32);
            this.selectMyDrives.Name = "selectMyDrives";
            this.selectMyDrives.Size = new System.Drawing.Size(295, 21);
            this.selectMyDrives.TabIndex = 6;
            this.selectMyDrives.SelectedIndexChanged += new System.EventHandler(this.selectMyDrives_SelectedIndexChanged);
            // 
            // listLocal
            // 
            this.listLocal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listLocal.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.icon,
            this.name,
            this.size,
            this.type,
            this.lastModified});
            this.listLocal.FullRowSelect = true;
            this.listLocal.Location = new System.Drawing.Point(2, 56);
            this.listLocal.Margin = new System.Windows.Forms.Padding(2);
            this.listLocal.MultiSelect = false;
            this.listLocal.Name = "listLocal";
            this.listLocal.Size = new System.Drawing.Size(343, 298);
            this.listLocal.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listLocal.TabIndex = 4;
            this.listLocal.UseCompatibleStateImageBehavior = false;
            this.listLocal.View = System.Windows.Forms.View.Details;
            this.listLocal.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listLocal_MouseDoubleClick);
            // 
            // icon
            // 
            this.icon.Text = "Icon";
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 350;
            // 
            // size
            // 
            this.size.Text = "Size";
            // 
            // type
            // 
            this.type.Text = "Type";
            // 
            // lastModified
            // 
            this.lastModified.Text = "Last Modified";
            this.lastModified.Width = 98;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(303, 33);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(38, 21);
            this.button4.TabIndex = 3;
            this.button4.Text = "Go";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCopyToRemote
            // 
            this.btnCopyToRemote.Location = new System.Drawing.Point(289, 5);
            this.btnCopyToRemote.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyToRemote.Name = "btnCopyToRemote";
            this.btnCopyToRemote.Size = new System.Drawing.Size(52, 22);
            this.btnCopyToRemote.TabIndex = 1;
            this.btnCopyToRemote.Text = ">>";
            this.btnCopyToRemote.UseVisualStyleBackColor = true;
            this.btnCopyToRemote.Click += new System.EventHandler(this.btnCopyToRemote_Click);
            // 
            // selectRemoteDrives
            // 
            this.selectRemoteDrives.FormattingEnabled = true;
            this.selectRemoteDrives.Location = new System.Drawing.Point(4, 32);
            this.selectRemoteDrives.Name = "selectRemoteDrives";
            this.selectRemoteDrives.Size = new System.Drawing.Size(280, 21);
            this.selectRemoteDrives.TabIndex = 5;
            this.selectRemoteDrives.SelectedIndexChanged += new System.EventHandler(this.selectRemoteDrives_SelectedIndexChanged);
            // 
            // listRemote
            // 
            this.listRemote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listRemote.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listRemote.FullRowSelect = true;
            this.listRemote.Location = new System.Drawing.Point(2, 56);
            this.listRemote.Margin = new System.Windows.Forms.Padding(2);
            this.listRemote.MultiSelect = false;
            this.listRemote.Name = "listRemote";
            this.listRemote.Size = new System.Drawing.Size(331, 298);
            this.listRemote.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listRemote.TabIndex = 4;
            this.listRemote.UseCompatibleStateImageBehavior = false;
            this.listRemote.View = System.Windows.Forms.View.Details;
            this.listRemote.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listRemote_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Icon";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Last Modified";
            this.columnHeader5.Width = 98;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 33);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 20);
            this.button2.TabIndex = 3;
            this.button2.Text = "Go";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnCopyFromRemote
            // 
            this.btnCopyFromRemote.Location = new System.Drawing.Point(2, 4);
            this.btnCopyFromRemote.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyFromRemote.Name = "btnCopyFromRemote";
            this.btnCopyFromRemote.Size = new System.Drawing.Size(54, 23);
            this.btnCopyFromRemote.TabIndex = 2;
            this.btnCopyFromRemote.Text = "<<";
            this.btnCopyFromRemote.UseVisualStyleBackColor = true;
            this.btnCopyFromRemote.Click += new System.EventHandler(this.btnCopyFromRemote_Click);
            // 
            // FileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 376);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FileManager";
            this.Text = "FileManager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCopyToRemote;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCopyFromRemote;
        private System.Windows.Forms.ListView listLocal;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader type;
        private System.Windows.Forms.ColumnHeader lastModified;
        private System.Windows.Forms.ColumnHeader icon;
        private System.Windows.Forms.ListView listRemote;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox selectMyDrives;
        private System.Windows.Forms.ComboBox selectRemoteDrives;
    }
}