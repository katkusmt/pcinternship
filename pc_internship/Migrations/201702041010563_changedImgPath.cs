namespace pc_internship.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedImgPath : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeModels", "ImgPath", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeModels", "ImgPath", c => c.Int(nullable: false));
        }
    }
}
