namespace cobaArray.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeAttributeItemsAndSupplierToPublic : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Name", c => c.String());
            AddColumn("dbo.Suppliers", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Suppliers", "Name");
            DropColumn("dbo.Items", "Name");
        }
    }
}
