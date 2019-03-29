namespace cobaArray.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_virtual_supplier_to_item : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Items", "Supplier_Id", "dbo.Suppliers");
            DropIndex("dbo.Items", new[] { "Supplier_Id" });
            RenameColumn(table: "dbo.Items", name: "Supplier_Id", newName: "Suppliers_Id");
            AlterColumn("dbo.Items", "Suppliers_Id", c => c.Int());
            CreateIndex("dbo.Items", "Suppliers_Id");
            AddForeignKey("dbo.Items", "Suppliers_Id", "dbo.Suppliers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Suppliers_Id", "dbo.Suppliers");
            DropIndex("dbo.Items", new[] { "Suppliers_Id" });
            AlterColumn("dbo.Items", "Suppliers_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Items", name: "Suppliers_Id", newName: "Supplier_Id");
            CreateIndex("dbo.Items", "Supplier_Id");
            AddForeignKey("dbo.Items", "Supplier_Id", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
    }
}
