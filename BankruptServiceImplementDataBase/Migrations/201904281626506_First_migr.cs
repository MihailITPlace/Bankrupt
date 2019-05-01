namespace BankruptServiceImplementDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First_migr : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Currencies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CurrencyRepositories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyId = c.Int(nullable: false),
                        RepositoryId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .ForeignKey("dbo.Repositories", t => t.RepositoryId, cascadeDelete: true)
                .Index(t => t.CurrencyId)
                .Index(t => t.RepositoryId);
            
            CreateTable(
                "dbo.Repositories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyId = c.Int(nullable: false),
                        ProviderId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Providers", t => t.ProviderId, cascadeDelete: true)
                .Index(t => t.ProviderId);
            
            CreateTable(
                "dbo.Providers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProviderFIO = c.String(nullable: false),
                        Email = c.String(),
                        PasswordHash = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RepositoryId = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        DateImplement = c.DateTime(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Repositories", t => t.RepositoryId, cascadeDelete: true)
                .Index(t => t.RepositoryId);
            
            CreateTable(
                "dbo.CurrencyTransactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CurrencyId = c.Int(nullable: false),
                        TransactionId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Currencies", t => t.CurrencyId, cascadeDelete: true)
                .ForeignKey("dbo.Transactions", t => t.TransactionId, cascadeDelete: true)
                .Index(t => t.CurrencyId)
                .Index(t => t.TransactionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transactions", "RepositoryId", "dbo.Repositories");
            DropForeignKey("dbo.CurrencyTransactions", "TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.CurrencyTransactions", "CurrencyId", "dbo.Currencies");
            DropForeignKey("dbo.Repositories", "ProviderId", "dbo.Providers");
            DropForeignKey("dbo.CurrencyRepositories", "RepositoryId", "dbo.Repositories");
            DropForeignKey("dbo.CurrencyRepositories", "CurrencyId", "dbo.Currencies");
            DropIndex("dbo.CurrencyTransactions", new[] { "TransactionId" });
            DropIndex("dbo.CurrencyTransactions", new[] { "CurrencyId" });
            DropIndex("dbo.Transactions", new[] { "RepositoryId" });
            DropIndex("dbo.Repositories", new[] { "ProviderId" });
            DropIndex("dbo.CurrencyRepositories", new[] { "RepositoryId" });
            DropIndex("dbo.CurrencyRepositories", new[] { "CurrencyId" });
            DropTable("dbo.CurrencyTransactions");
            DropTable("dbo.Transactions");
            DropTable("dbo.Providers");
            DropTable("dbo.Repositories");
            DropTable("dbo.CurrencyRepositories");
            DropTable("dbo.Currencies");
        }
    }
}
