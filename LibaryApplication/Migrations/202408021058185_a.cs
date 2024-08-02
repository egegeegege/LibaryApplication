namespace LibaryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KitapAdı = c.String(),
                        BaskıSayısı = c.Int(nullable: false),
                        SayfaSayısı = c.Int(nullable: false),
                        Yayınevi = c.String(),
                        Yazar = c.String(),
                        BasımYılı = c.Int(nullable: false),
                        CiltNo = c.Int(nullable: false),
                        ImageUrl = c.String(),
                        AddDate = c.DateTime(nullable: false),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Kullanıcı",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        Email = c.String(),
                        TelefonNo = c.String(),
                        Sifre = c.String(),
                        AddDate = c.DateTime(nullable: false),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Kullanıcı");
            DropTable("dbo.Kitaps");
        }
    }
}
