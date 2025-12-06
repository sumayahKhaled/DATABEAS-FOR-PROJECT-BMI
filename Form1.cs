using final_Project.Data;
using final_Project.Models;
using System;
using System.Windows.Forms;

namespace final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            this.results.Click += results_Click;


            this.Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void results_Click(object sender, EventArgs e)
        {
            string userName = iName.Text.Trim();

            double height;
            double weight;

            if (string.IsNullOrWhiteSpace(userName) ||
                !double.TryParse(iHeight.Text, out height) || height <= 0 ||
                !double.TryParse(iWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show(
                    "الرجاء إدخال الاسم والطول والوزن بشكل صحيح.",
                    "خطأ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }


            double heightInMeters = height / 100.0;
            double bmiValue = weight / (heightInMeters * heightInMeters);
            string bmiCategory = GetBMICategory(bmiValue);


            Form2 resultForm = new Form2(userName, height, weight, bmiValue, bmiCategory);

            this.Hide();
            resultForm.ShowDialog();
            this.Show();
        }



        private string GetBMICategory(double bmi)
        {
            if (bmi < 18.5) return "نحافة (Underweight)";
            if (bmi < 25) return "وزن صحي (Healthy Weight)";
            if (bmi < 30) return "زيادة وزن (Overweight)";
            return "سمنة (Obesity)";
        }



        private void SaveMeasurementRecord(string userName, double height, double weight, double bmiValue, string bmiCategory, AppDbContext db)
        {
            try
            {
                using (var db = new AppDbContext())
                {
                    var record = new MeasurementRecord
                    {
                        UserName = userName,
                        Date = DateTime.Now,
                        Height = height,
                        Weight = weight,
                        BMIValue = bmiValue,
                        BMICategory = bmiCategory
                    };

                    db.Measurements.Add(record);
                   db.SaveChanges();
                }
            }
            catch
            {
                MessageBox.Show("خطأ أثناء الحفظ في قاعدة البيانات");
            }
        }
    }
}
