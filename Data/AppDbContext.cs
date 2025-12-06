using System.Data.Entity;
using final_Project.Models;

namespace final_Project.Data
{
    // الآن، هذا الكلاس يتعامل فقط مع جدول سجلات القياس (Measurements)
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("HealthyLifeDbConnection")
        {
        }

        // تم حذف DbSet<User> Users لأن جدول المستخدمين حذف
        public DbSet<MeasurementRecord> Measurements { get; set; }
    }
}