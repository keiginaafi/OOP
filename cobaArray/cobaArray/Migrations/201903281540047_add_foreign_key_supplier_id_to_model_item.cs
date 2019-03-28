namespace cobaArray.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_foreign_key_supplier_id_to_model_item : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Supplier_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Items", "Supplier_Id");
            AddForeignKey("dbo.Items", "Supplier_Id", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Supplier_Id", "dbo.Suppliers");
            DropIndex("dbo.Items", new[] { "Supplier_Id" });
            DropColumn("dbo.Items", "Supplier_Id");
        }
    }
}
