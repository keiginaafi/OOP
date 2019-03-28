namespace cobaArray.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_isdelete_to_item : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "IsDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "IsDelete");
        }
    }
}
