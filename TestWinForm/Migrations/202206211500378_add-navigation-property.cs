namespace TestWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnavigationproperty : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NguyenLieuMonAns",
                c => new
                    {
                        NguyenLieu_Id = c.Int(nullable: false),
                        MonAn_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.NguyenLieu_Id, t.MonAn_Id })
                .ForeignKey("dbo.NguyenLieux", t => t.NguyenLieu_Id, cascadeDelete: true)
                .ForeignKey("dbo.MonAns", t => t.MonAn_Id, cascadeDelete: true)
                .Index(t => t.NguyenLieu_Id)
                .Index(t => t.MonAn_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NguyenLieuMonAns", "MonAn_Id", "dbo.MonAns");
            DropForeignKey("dbo.NguyenLieuMonAns", "NguyenLieu_Id", "dbo.NguyenLieux");
            DropIndex("dbo.NguyenLieuMonAns", new[] { "MonAn_Id" });
            DropIndex("dbo.NguyenLieuMonAns", new[] { "NguyenLieu_Id" });
            DropTable("dbo.NguyenLieuMonAns");
        }
    }
}
