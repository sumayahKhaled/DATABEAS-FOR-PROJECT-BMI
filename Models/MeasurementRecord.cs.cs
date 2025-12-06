using System;
using System.ComponentModel.DataAnnotations;
// تم حذف System.ComponentModel.DataAnnotations.Schema لأنه لم يعد لدينا مفاتيح أجنبية

namespace final_Project.Models
{
    public class MeasurementRecord
    {
        // المفتاح الرئيسي للسجل
        [Key]
        public int RecordId { get; set; }

        // بما أن جدول المستخدمين حذف، نضيف عمود لاسم الشخص ليصبح السجل مستقلاً
        public string UserName { get; set; }

        // تاريخ ووقت تسجيل القياس
        public DateTime Date { get; set; }

        // الطول (نستخدم double للأرقام العشرية)
        public double Height { get; set; }

        // الوزن
        public double Weight { get; set; }

        // قيمة مؤشر كتلة الجسم المحسوبة
        public double BMIValue { get; set; }

        // تصنيف الحالة (نحيف، طبيعي، إلخ)
        public string BMICategory { get; set; }

        // تم حذف الأسطر التالية لأنها كانت تربط بجدول User المحذوف:
        // public int UserId { get; set; }
        // [ForeignKey("UserId")]
        // public virtual User User { get; set; }
    }
}