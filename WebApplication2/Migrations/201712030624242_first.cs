namespace WebApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "email", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Users", "email");
            DropColumn("dbo.Users", "id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "id", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Users");
            AlterColumn("dbo.Users", "email", c => c.String());
            AddPrimaryKey("dbo.Users", "id");
        }
    }
}
