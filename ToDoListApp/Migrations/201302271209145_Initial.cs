namespace ToDoListApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ToDoItems",
                c => new
                    {
                        ToDoItemId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsComplete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ToDoItemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ToDoItems");
        }
    }
}
