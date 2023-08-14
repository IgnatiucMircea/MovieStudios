namespace dbms_studio
{
    partial class Form1
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
            this.parentgrid = new System.Windows.Forms.DataGridView();
            this.childgrid = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.insertButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.parentLabel = new System.Windows.Forms.Label();
            this.childLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.parentgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // parentgrid
            // 
            this.parentgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentgrid.Location = new System.Drawing.Point(24, 31);
            this.parentgrid.Name = "parentgrid";
            this.parentgrid.RowHeadersWidth = 51;
            this.parentgrid.RowTemplate.Height = 24;
            this.parentgrid.Size = new System.Drawing.Size(240, 150);
            this.parentgrid.TabIndex = 0;
            // 
            // childgrid
            // 
            this.childgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.childgrid.Location = new System.Drawing.Point(312, 31);
            this.childgrid.Name = "childgrid";
            this.childgrid.RowHeadersWidth = 51;
            this.childgrid.RowTemplate.Height = 24;
            this.childgrid.Size = new System.Drawing.Size(254, 150);
            this.childgrid.TabIndex = 1;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(24, 202);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(203, 236);
            this.flowLayoutPanel.TabIndex = 2;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(647, 31);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(75, 23);
            this.insertButton.TabIndex = 3;
            this.insertButton.Text = "insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(647, 158);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(647, 90);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // parentLabel
            // 
            this.parentLabel.AutoSize = true;
            this.parentLabel.Location = new System.Drawing.Point(30, 9);
            this.parentLabel.Name = "parentLabel";
            this.parentLabel.Size = new System.Drawing.Size(44, 16);
            this.parentLabel.TabIndex = 6;
            this.parentLabel.Text = "label1";
            this.parentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // childLabel
            // 
            this.childLabel.AutoSize = true;
            this.childLabel.Location = new System.Drawing.Point(309, 12);
            this.childLabel.Name = "childLabel";
            this.childLabel.Size = new System.Drawing.Size(44, 16);
            this.childLabel.TabIndex = 7;
            this.childLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.childLabel);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.childgrid);
            this.Controls.Add(this.parentgrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parentgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView parentgrid;
        private System.Windows.Forms.DataGridView childgrid;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label parentLabel;
        private System.Windows.Forms.Label childLabel;
    }
}

