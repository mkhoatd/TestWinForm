namespace TestWinForm.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MonAnNguyenLieux",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 5),
                        SoLuong = c.Int(nullable: false),
                        DonViTinh = c.String(),
                        MonAnId = c.Int(nullable: false),
                        NguyenLieuId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MonAns", t => t.MonAnId, cascadeDelete: true)
                .ForeignKey("dbo.NguyenLieux", t => t.NguyenLieuId, cascadeDelete: true)
                .Index(t => t.MonAnId)
                .Index(t => t.NguyenLieuId);
            
            CreateTable(
                "dbo.MonAns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenMonAn = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.NguyenLieux",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenNguyenLieu = c.String(),
                        TinhTrang = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MonAnNguyenLieux", "NguyenLieuId", "dbo.NguyenLieux");
            DropForeignKey("dbo.MonAnNguyenLieux", "MonAnId", "dbo.MonAns");
            DropIndex("dbo.MonAnNguyenLieux", new[] { "NguyenLieuId" });
            DropIndex("dbo.MonAnNguyenLieux", new[] { "MonAnId" });
            DropTable("dbo.NguyenLieux");
            DropTable("dbo.MonAns");
            DropTable("dbo.MonAnNguyenLieux");
        }
    }
}
