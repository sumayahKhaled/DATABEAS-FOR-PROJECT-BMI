using final_Project.Data;
using final_Project.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace final_Project
{
    public partial class Form2 : Form
    {
        private string _userName;
        private double _height;
        private double _weight;
        private double _bmiValue;
        private string _bmiCategory;

       
        public Form2(string userName, double height, double weight, double bmiValue, string bmiCategory)
        {
            InitializeComponent();

           
            _userName = userName;
            _height = height;
            _weight = weight;
            _bmiValue = bmiValue;
            _bmiCategory = bmiCategory;
        }

       
        private void Form2_Load(object sender, EventArgs e)
        {
            
            reWeight.Text = $"{_weight:F2} ﬂÃ„";
            reHeight.Text = $"{_height:F2} ”„";
            reBMI.Text = $"{_bmiValue:F2}";
            reHealthStatus.Text = _bmiCategory;
            reConditionDescription.Text = GetConditionDescription(_bmiCategory);
        }

        private void saveResult_Click(object sender, EventArgs e)
        {
            SaveMeasurementRecord(_userName, _height, _weight, _bmiValue, _bmiCategory);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void record_Click(object sender, EventArgs e)
        {

            Form3 recordForm = new Form3();
            recordForm.ShowDialog();
        }

        private void SaveMeasurementRecord(string userName, double height, double weight, double bmiValue, string bmiCategory)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var newRecord = new MeasurementRecord
                    {
                        UserName = userName,
                        Date = DateTime.Now,
                        Height = height,
                        Weight = weight,
                        BMIValue = bmiValue,
                        BMICategory = bmiCategory
                    };

                    db.Measurements.Add(newRecord);
                    db.SaveChanges();

                    MessageBox.Show(" „ Õ›Ÿ »Ì«‰« ﬂ »‰Ã«Õ ›Ì ﬁ«⁄œ… «·»Ì«‰« .", "‰Ã«Õ «·Õ›Ÿ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ÕœÀ Œÿ√ √À‰«¡ Õ›Ÿ «·»Ì«‰« : " + ex.Message, "Œÿ√ ›Ì ﬁ«⁄œ… «·»Ì«‰« ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetConditionDescription(string bmiCategory)
        {
            if (bmiCategory.Contains("‰Õ«›…")) return " Õ «Ã ·“Ì«œ… «·Ê“‰ Ê«·«Â „«„ »«· €–Ì….";
            if (bmiCategory.Contains("’ÕÌ")) return " Â«‰Ì‰«! Ê“‰ﬂ „À«·Ì ÊÕ«· ﬂ „„ «“….";
            if (bmiCategory.Contains("“Ì«œ… Ê“‰")) return "ÌÊ’Ï »»⁄÷ «·‰‘«ÿ «·»œ‰Ì Ê«·Õ„Ì… «·„ Ê«“‰….";
            if (bmiCategory.Contains("”„‰…")) return "Ì‰»€Ì «” ‘«—… ÿ»Ì» √Ê „Œ ’  €–Ì… ·»œ¡ Œÿ… ’ÕÌ….";
            return "»Ì«‰«  €Ì— ﬂ«›Ì….";
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            

            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.ResumeLayout(false);

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
