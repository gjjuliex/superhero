namespace SuperheroProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIdPropertytosuperheromodel : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SuperheroProjs");
            AddColumn("dbo.SuperheroProjs", "Id", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.SuperheroProjs", "Name", c => c.String());
            AddPrimaryKey("dbo.SuperheroProjs", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SuperheroProjs");
            AlterColumn("dbo.SuperheroProjs", "Name", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.SuperheroProjs", "Id");
            AddPrimaryKey("dbo.SuperheroProjs", "Name");
        }
    }
}
