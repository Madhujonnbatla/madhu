namespace Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpReport : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emps", "EmpReport", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emps", "EmpReport");
        }
    }
}
