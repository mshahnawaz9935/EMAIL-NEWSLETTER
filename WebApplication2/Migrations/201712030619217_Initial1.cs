namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Users", "id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "id", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "id");
        }
    }
}
