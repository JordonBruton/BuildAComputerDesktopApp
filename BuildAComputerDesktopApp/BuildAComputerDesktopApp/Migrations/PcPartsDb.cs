namespace BuildAComputerDesktopApp.Migrations
{ 
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CPUs",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        brand = c.String(),
                        gen = c.String(),
                        socket = c.String(),
                        core = c.Int(nullable: false),
                        thread = c.Int(nullable: false),
                        speed = c.Decimal(nullable: false, precision: 18, scale: 2),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        series = c.String(),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.GPUs",
                c => new
                    {
                        gpu = c.String(nullable: false, maxLength: 128),
                        GPUmemory = c.Int(nullable: false),
                        memoryType = c.String(),
                        memoryInterface = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.gpu);
            
            CreateTable(
                "dbo.Memories",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        brand = c.String(),
                        capacity = c.Int(nullable: false),
                        speed = c.Int(nullable: false),
                        timing = c.String(),
                        price = c.String(),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.MotherBoards",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        brand = c.String(),
                        socket = c.String(),
                        chipset = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        usbPorts = c.Int(nullable: false),
                        PCIthree = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.name);
            
            CreateTable(
                "dbo.PCs",
                c => new
                    {
                        PCId = c.Int(nullable: false, identity: true),
                        CPU_name = c.String(nullable: false, maxLength: 128),
                        GPU_gpu = c.String(nullable: false, maxLength: 128),
                        Memory_name = c.String(nullable: false, maxLength: 128),
                        Mobo_name = c.String(nullable: false, maxLength: 128),
                        PowerSupply_name = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PCId)
                .ForeignKey("dbo.CPUs", t => t.CPU_name, cascadeDelete: true)
                .ForeignKey("dbo.GPUs", t => t.GPU_gpu, cascadeDelete: true)
                .ForeignKey("dbo.Memories", t => t.Memory_name, cascadeDelete: true)
                .ForeignKey("dbo.MotherBoards", t => t.Mobo_name, cascadeDelete: true)
                .ForeignKey("dbo.PowerSupplies", t => t.PowerSupply_name, cascadeDelete: true)
                .Index(t => t.CPU_name)
                .Index(t => t.GPU_gpu)
                .Index(t => t.Memory_name)
                .Index(t => t.Mobo_name)
                .Index(t => t.PowerSupply_name);
            
            CreateTable(
                "dbo.PowerSupplies",
                c => new
                    {
                        name = c.String(nullable: false, maxLength: 128),
                        brand = c.String(),
                        maxPower = c.Int(nullable: false),
                        fans = c.Int(nullable: false),
                        energyEfficiency = c.String(),
                        weight = c.Decimal(nullable: false, precision: 18, scale: 2),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.name);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PCs", "PowerSupply_name", "dbo.PowerSupplies");
            DropForeignKey("dbo.PCs", "Mobo_name", "dbo.MotherBoards");
            DropForeignKey("dbo.PCs", "Memory_name", "dbo.Memories");
            DropForeignKey("dbo.PCs", "GPU_gpu", "dbo.GPUs");
            DropForeignKey("dbo.PCs", "CPU_name", "dbo.CPUs");
            DropIndex("dbo.PCs", new[] { "PowerSupply_name" });
            DropIndex("dbo.PCs", new[] { "Mobo_name" });
            DropIndex("dbo.PCs", new[] { "Memory_name" });
            DropIndex("dbo.PCs", new[] { "GPU_gpu" });
            DropIndex("dbo.PCs", new[] { "CPU_name" });
            DropTable("dbo.PowerSupplies");
            DropTable("dbo.PCs");
            DropTable("dbo.MotherBoards");
            DropTable("dbo.Memories");
            DropTable("dbo.GPUs");
            DropTable("dbo.CPUs");
        }
    }
}
