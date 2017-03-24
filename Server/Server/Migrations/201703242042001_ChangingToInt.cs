namespace Server.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingToInt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Statistics", "Steps", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Statistics", "Steps");
        }
    }
}
