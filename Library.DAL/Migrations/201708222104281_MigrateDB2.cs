namespace Library.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Book");
            DropPrimaryKey("dbo.Brochure");
            DropPrimaryKey("dbo.Magazine");
            AddColumn("dbo.Book", "CreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Brochure", "CreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Magazine", "CreationDate", c => c.DateTime(nullable: false));
            //AlterColumn("dbo.Book", "Id", c => c.Guid(nullable: false));
            DropColumn("dbo.Book", "Id");
            AddColumn("dbo.Book", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Book", "YearOfPublishing", c => c.DateTime(nullable: false));
            //AlterColumn("dbo.Brochure", "Id", c => c.Guid(nullable: false));
            DropColumn("dbo.Brochure", "Id");
            AddColumn("dbo.Brochure", "Id", c => c.Guid(nullable: false));
            // AlterColumn("dbo.Magazine", "Id", c => c.Guid(nullable: false));
            DropColumn("dbo.Magazine", "Id");
            AddColumn("dbo.Magazine", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Magazine", "YearOfPublishing", c => c.DateTime(nullable: false));
            AddPrimaryKey("dbo.Book", "Id");
            AddPrimaryKey("dbo.Brochure", "Id");
            AddPrimaryKey("dbo.Magazine", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Magazine");
            DropPrimaryKey("dbo.Brochure");
            DropPrimaryKey("dbo.Book");
            AlterColumn("dbo.Magazine", "YearOfPublishing", c => c.DateTime(nullable: false, storeType: "date"));
            //AlterColumn("dbo.Magazine", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Magazine", "Id");
            AddColumn("dbo.Magazine", "Id", c => c.Guid(nullable: false));
            //AlterColumn("dbo.Brochure", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Brochure", "Id");
            AddColumn("dbo.Brochure", "Id", c => c.Guid(nullable: false));
            AlterColumn("dbo.Book", "YearOfPublishing", c => c.DateTime(nullable: false, storeType: "date"));
            //AlterColumn("dbo.Book", "Id", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Book", "Id");
            AddColumn("dbo.Book", "Id", c => c.Guid(nullable: false));
            DropColumn("dbo.Magazine", "CreationDate");
            DropColumn("dbo.Brochure", "CreationDate");
            DropColumn("dbo.Book", "CreationDate");
            AddPrimaryKey("dbo.Magazine", "Id");
            AddPrimaryKey("dbo.Brochure", "Id");
            AddPrimaryKey("dbo.Book", "Id");
        }
    }
}
