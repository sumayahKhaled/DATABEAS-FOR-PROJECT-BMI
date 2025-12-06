namespace final_Project
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
            this.iName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.results = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lWeight = new System.Windows.Forms.Label();
            this.iWeight = new System.Windows.Forms.TextBox();
            this.lHeight = new System.Windows.Forms.Label();
            this.iHeight = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iName
            // 
            this.iName.Location = new System.Drawing.Point(29, 44);
            this.iName.Name = "iName";
            this.iName.Size = new System.Drawing.Size(287, 26);
            this.iName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.results);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lWeight);
            this.panel1.Controls.Add(this.iWeight);
            this.panel1.Controls.Add(this.lHeight);
            this.panel1.Controls.Add(this.iHeight);
            this.panel1.Controls.Add(this.lName);
            this.panel1.Controls.Add(this.iName);
            this.panel1.Location = new System.Drawing.Point(179, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 280);
            this.panel1.TabIndex = 1;
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.SystemColors.Highlight;
            this.results.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.results.ForeColor = System.Drawing.Color.Transparent;
            this.results.Location = new System.Drawing.Point(29, 200);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(287, 33);
            this.results.TabIndex = 8;
            this.results.Text = "إحسب";
            this.results.UseVisualStyleBackColor = false;
            // ***************************************************************
            // تم إضافة سطر ربط الحدث هنا
            this.results.Click += new System.EventHandler(this.results_Click);
            // ***************************************************************
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 7;
            // 
            // lWeight
            // 
            this.lWeight.AutoSize = true;
            this.lWeight.Location = new System.Drawing.Point(275, 126);
            this.lWeight.Name = "lWeight";
            this.lWeight.Size = new System.Drawing.Size(38, 18);
            this.lWeight.TabIndex = 5;
            this.lWeight.Text = "الوزن:";
            // 
            // iWeight
            // 
            this.iWeight.Location = new System.Drawing.Point(29, 147);
            this.iWeight.Name = "iWeight";
            this.iWeight.Size = new System.Drawing.Size(287, 26);
            this.iWeight.TabIndex = 4;
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(266, 74);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(46, 18);
            this.lHeight.TabIndex = 3;
            this.lHeight.Text = "الطول:";
            // 
            // iHeight
            // 
            this.iHeight.Location = new System.Drawing.Point(29, 95);
            this.iHeight.Name = "iHeight";
            this.iHeight.Size = new System.Drawing.Size(287, 26);
            this.iHeight.TabIndex = 2;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(275, 23);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(43, 18);
            this.lName.TabIndex = 1;
            this.lName.Text = "الإسم:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(700, 506);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tajawal", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        } // نهاية InitializeComponent() بشكل صحيح

        #endregion // نهاية #region Windows Form Designer generated code بشكل صحيح

        private System.Windows.Forms.TextBox iName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button results;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lWeight;
        private System.Windows.Forms.TextBox iWeight;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.TextBox iHeight;
        private System.Windows.Forms.Label lName;
    }
}