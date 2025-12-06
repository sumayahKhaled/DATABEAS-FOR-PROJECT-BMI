
namespace final_Project
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.saveResult = new System.Windows.Forms.Button();
            this.reWeight = new System.Windows.Forms.Label();
            this.reHeight = new System.Windows.Forms.Label();
            this.reBMI = new System.Windows.Forms.Label();
            this.reConditionDescription = new System.Windows.Forms.Label();
            this.reHealthStatus = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.height = new System.Windows.Forms.Label();
            this.ConditionDescription = new System.Windows.Forms.Label();
            this.HealthStatus = new System.Windows.Forms.Label();
            this.BMI = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.saveResult);
            this.panel1.Controls.Add(this.reWeight);
            this.panel1.Controls.Add(this.reHeight);
            this.panel1.Controls.Add(this.reBMI);
            this.panel1.Controls.Add(this.reConditionDescription);
            this.panel1.Controls.Add(this.reHealthStatus);
            this.panel1.Controls.Add(this.weight);
            this.panel1.Controls.Add(this.height);
            this.panel1.Controls.Add(this.ConditionDescription);
            this.panel1.Controls.Add(this.HealthStatus);
            this.panel1.Controls.Add(this.BMI);
            this.panel1.Location = new System.Drawing.Point(182, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 306);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.ForeColor = System.Drawing.Color.Transparent;
            this.Back.Location = new System.Drawing.Point(20, 249);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(133, 33);
            this.Back.TabIndex = 12;
            this.Back.Text = "رجوع";
            this.Back.UseVisualStyleBackColor = false;
            // 
            // saveResult
            // 
            this.saveResult.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveResult.Font = new System.Drawing.Font("Tajawal", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveResult.ForeColor = System.Drawing.Color.Transparent;
            this.saveResult.Location = new System.Drawing.Point(191, 249);
            this.saveResult.Name = "saveResult";
            this.saveResult.Size = new System.Drawing.Size(133, 33);
            this.saveResult.TabIndex = 11;
            this.saveResult.Text = "حفظ النتيجة";
            this.saveResult.UseVisualStyleBackColor = false;
            // 
            // reWeight
            // 
            this.reWeight.AutoSize = true;
            this.reWeight.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reWeight.Location = new System.Drawing.Point(34, 28);
            this.reWeight.Name = "reWeight";
            this.reWeight.Size = new System.Drawing.Size(111, 29);
            this.reWeight.TabIndex = 10;
            this.reWeight.Text = "نتيجة الوزن";
            // 
            // reHeight
            // 
            this.reHeight.AutoSize = true;
            this.reHeight.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reHeight.Location = new System.Drawing.Point(34, 71);
            this.reHeight.Name = "reHeight";
            this.reHeight.Size = new System.Drawing.Size(111, 29);
            this.reHeight.TabIndex = 9;
            this.reHeight.Text = "نتيجة الطول";
            this.reHeight.Click += new System.EventHandler(this.label10_Click);
            // 
            // reBMI
            // 
            this.reBMI.AutoSize = true;
            this.reBMI.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reBMI.Location = new System.Drawing.Point(20, 117);
            this.reBMI.Name = "reBMI";
            this.reBMI.Size = new System.Drawing.Size(125, 29);
            this.reBMI.TabIndex = 8;
            this.reBMI.Text = "نتيجة ال BMI";
            // 
            // reConditionDescription
            // 
            this.reConditionDescription.AutoSize = true;
            this.reConditionDescription.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reConditionDescription.Location = new System.Drawing.Point(13, 203);
            this.reConditionDescription.Name = "reConditionDescription";
            this.reConditionDescription.Size = new System.Drawing.Size(130, 29);
            this.reConditionDescription.TabIndex = 7;
            this.reConditionDescription.Text = "نتيجة الوصف";
            // 
            // reHealthStatus
            // 
            this.reHealthStatus.AutoSize = true;
            this.reHealthStatus.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reHealthStatus.Location = new System.Drawing.Point(20, 162);
            this.reHealthStatus.Name = "reHealthStatus";
            this.reHealthStatus.Size = new System.Drawing.Size(123, 29);
            this.reHealthStatus.TabIndex = 6;
            this.reHealthStatus.Text = "نتيجة الحاله ";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight.Location = new System.Drawing.Point(267, 28);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(64, 29);
            this.weight.TabIndex = 5;
            this.weight.Text = "الوزن:";
            // 
            // height
            // 
            this.height.AutoSize = true;
            this.height.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height.Location = new System.Drawing.Point(256, 71);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(75, 29);
            this.height.TabIndex = 4;
            this.height.Text = "الطول:";
            // 
            // ConditionDescription
            // 
            this.ConditionDescription.AutoSize = true;
            this.ConditionDescription.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConditionDescription.Location = new System.Drawing.Point(205, 203);
            this.ConditionDescription.Name = "ConditionDescription";
            this.ConditionDescription.Size = new System.Drawing.Size(126, 29);
            this.ConditionDescription.TabIndex = 3;
            this.ConditionDescription.Text = "وصف الحاله:";
            // 
            // HealthStatus
            // 
            this.HealthStatus.AutoSize = true;
            this.HealthStatus.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthStatus.Location = new System.Drawing.Point(188, 162);
            this.HealthStatus.Name = "HealthStatus";
            this.HealthStatus.Size = new System.Drawing.Size(143, 29);
            this.HealthStatus.TabIndex = 2;
            this.HealthStatus.Text = "الحاله الصحية:";
            // 
            // BMI
            // 
            this.BMI.AutoSize = true;
            this.BMI.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMI.Location = new System.Drawing.Point(258, 117);
            this.BMI.Name = "BMI";
            this.BMI.Size = new System.Drawing.Size(73, 29);
            this.BMI.TabIndex = 1;
            this.BMI.Text = "الـ BMI:";
            this.BMI.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Tajawal", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(264, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 80);
            this.label5.TabIndex = 9;
            this.label5.Text = "النتيجة";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // record
            // 
            this.record.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.record.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.record.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.record.CausesValidation = false;
            this.record.FlatAppearance.BorderSize = 0;
            this.record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.record.Font = new System.Drawing.Font("Tajawal", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.ForeColor = System.Drawing.SystemColors.Highlight;
            this.record.Location = new System.Drawing.Point(572, 28);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(97, 33);
            this.record.TabIndex = 13;
            this.record.Text = "السجل";
            this.record.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(700, 506);
            this.Controls.Add(this.record);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tajawal", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form2_Load);

            // **************
            // 💥 أسطر الربط (Event Handlers) المضافة حديثاً
            // **************
            this.saveResult.Click += new System.EventHandler(this.saveResult_Click);
            this.Back.Click += new System.EventHandler(this.Back_Click);
            this.record.Click += new System.EventHandler(this.record_Click);
            // **************

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label BMI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label height;
        private System.Windows.Forms.Label ConditionDescription;
        private System.Windows.Forms.Label HealthStatus;
        private System.Windows.Forms.Label reWeight;
        private System.Windows.Forms.Label reHeight;
        private System.Windows.Forms.Label reBMI;
        private System.Windows.Forms.Label reConditionDescription;
        private System.Windows.Forms.Label reHealthStatus;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button saveResult;
        private System.Windows.Forms.Button record;
    }
}