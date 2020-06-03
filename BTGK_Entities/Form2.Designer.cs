namespace BTGK_Entities
{
    partial class Form2
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
            this.cbbNameLop = new System.Windows.Forms.ComboBox();
            this.lbNameLop = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.btnCanCel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNameSV = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbbNameLop
            // 
            this.cbbNameLop.FormattingEnabled = true;
            this.cbbNameLop.Location = new System.Drawing.Point(413, 47);
            this.cbbNameLop.Margin = new System.Windows.Forms.Padding(2);
            this.cbbNameLop.Name = "cbbNameLop";
            this.cbbNameLop.Size = new System.Drawing.Size(92, 21);
            this.cbbNameLop.TabIndex = 24;
            // 
            // lbNameLop
            // 
            this.lbNameLop.AutoSize = true;
            this.lbNameLop.Location = new System.Drawing.Point(410, 26);
            this.lbNameLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNameLop.Name = "lbNameLop";
            this.lbNameLop.Size = new System.Drawing.Size(53, 13);
            this.lbNameLop.TabIndex = 20;
            this.lbNameLop.Text = "NameLop";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(324, 26);
            this.lbAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(26, 13);
            this.lbAge.TabIndex = 21;
            this.lbAge.Text = "Age";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(159, 26);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(49, 13);
            this.lbName.TabIndex = 22;
            this.lbName.Text = "NameSV";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(40, 26);
            this.lbMSSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(37, 13);
            this.lbMSSV.TabIndex = 23;
            this.lbMSSV.Text = "MSSV";
            // 
            // btnCanCel
            // 
            this.btnCanCel.Location = new System.Drawing.Point(321, 95);
            this.btnCanCel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCanCel.Name = "btnCanCel";
            this.btnCanCel.Size = new System.Drawing.Size(56, 19);
            this.btnCanCel.TabIndex = 19;
            this.btnCanCel.Text = "Cancel";
            this.btnCanCel.UseVisualStyleBackColor = true;
            this.btnCanCel.Click += new System.EventHandler(this.btnCanCel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(162, 95);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 19);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(324, 47);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(53, 20);
            this.txtAge.TabIndex = 15;
            // 
            // txtNameSV
            // 
            this.txtNameSV.Location = new System.Drawing.Point(162, 47);
            this.txtNameSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtNameSV.Name = "txtNameSV";
            this.txtNameSV.Size = new System.Drawing.Size(133, 20);
            this.txtNameSV.TabIndex = 16;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(43, 47);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(75, 20);
            this.txtMSSV.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 141);
            this.Controls.Add(this.cbbNameLop);
            this.Controls.Add(this.lbNameLop);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMSSV);
            this.Controls.Add(this.btnCanCel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtNameSV);
            this.Controls.Add(this.txtMSSV);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbNameLop;
        private System.Windows.Forms.Label lbNameLop;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.Button btnCanCel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNameSV;
        private System.Windows.Forms.TextBox txtMSSV;
    }
}