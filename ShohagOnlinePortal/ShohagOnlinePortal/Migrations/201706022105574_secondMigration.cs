namespace ShohagOnlinePortal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SubmitMeContacts", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.SubmitMeContacts", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.SubmitMeContacts", "MobileNo", c => c.String(nullable: false));
            AlterColumn("dbo.SubmitMeContacts", "Message", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SubmitMeContacts", "Message", c => c.String());
            AlterColumn("dbo.SubmitMeContacts", "MobileNo", c => c.String());
            AlterColumn("dbo.SubmitMeContacts", "Email", c => c.String());
            AlterColumn("dbo.SubmitMeContacts", "Name", c => c.String());
        }
    }
}
