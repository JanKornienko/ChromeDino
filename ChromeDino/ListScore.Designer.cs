namespace ChromeDino
{
    partial class ListScore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListScore));
            this.labelText = new System.Windows.Forms.Label();
            this.listTxt = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.writeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelText
            // 
            this.labelText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.ForeColor = System.Drawing.Color.DimGray;
            this.labelText.Location = new System.Drawing.Point(26, 9);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(184, 45);
            this.labelText.TabIndex = 2;
            this.labelText.Text = "Dashboard";
            // 
            // listTxt
            // 
            this.listTxt.BackColor = System.Drawing.SystemColors.Control;
            this.listTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTxt.Cursor = System.Windows.Forms.Cursors.Default;
            this.listTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listTxt.Location = new System.Drawing.Point(12, 139);
            this.listTxt.Multiline = true;
            this.listTxt.Name = "listTxt";
            this.listTxt.ReadOnly = true;
            this.listTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.listTxt.Size = new System.Drawing.Size(209, 254);
            this.listTxt.TabIndex = 3;
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(49, 399);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(129, 35);
            this.closeBtn.TabIndex = 4;
            this.closeBtn.Text = "Hrát znovu";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // nameText
            // 
            this.nameText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nameText.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(12, 57);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(209, 35);
            this.nameText.TabIndex = 5;
            // 
            // writeBtn
            // 
            this.writeBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeBtn.Location = new System.Drawing.Point(67, 98);
            this.writeBtn.Name = "writeBtn";
            this.writeBtn.Size = new System.Drawing.Size(99, 35);
            this.writeBtn.TabIndex = 6;
            this.writeBtn.Text = "Zapsat";
            this.writeBtn.UseVisualStyleBackColor = true;
            this.writeBtn.Click += new System.EventHandler(this.writeBtn_Click);
            // 
            // ListScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 442);
            this.Controls.Add(this.writeBtn);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.listTxt);
            this.Controls.Add(this.labelText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(249, 481);
            this.MinimumSize = new System.Drawing.Size(249, 481);
            this.Name = "ListScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "T-Rex";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.TextBox listTxt;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button writeBtn;
    }
}