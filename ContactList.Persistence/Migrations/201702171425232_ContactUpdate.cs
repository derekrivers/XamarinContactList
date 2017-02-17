namespace ContactList.Persistence.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactUpdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Name", c => c.String());
        }
    }
}
