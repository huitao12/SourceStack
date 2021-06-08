namespace EF6Sample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addIsmale : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "IsMale", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "IsMale");
        }
    }
}
