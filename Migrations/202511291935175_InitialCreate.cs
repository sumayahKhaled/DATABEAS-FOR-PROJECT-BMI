namespace final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MeasurementRecords",
                c => new
                    {
                        RecordId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Date = c.DateTime(nullable: false),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        BMIValue = c.Double(nullable: false),
                        BMICategory = c.String(),
                    })
                .PrimaryKey(t => t.RecordId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MeasurementRecords");
        }
    }
}
