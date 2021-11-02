namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Toton : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Tipo_Documento = c.String(nullable: false, maxLength: 128),
                        Documento = c.Int(nullable: false),
                        Primer_Nombre = c.String(maxLength: 30),
                        Segundo_Nombre = c.String(maxLength: 30),
                        Primer_Apellido = c.String(maxLength: 30),
                        Segundo_Apellido = c.String(maxLength: 30),
                        Celular = c.String(maxLength: 10),
                        Direccion = c.String(maxLength: 200),
                        Email = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => new { t.Tipo_Documento, t.Documento })
                .ForeignKey("dbo.Tipos_Documento", t => t.Tipo_Documento, cascadeDelete: true)
                .Index(t => t.Tipo_Documento);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Valor_Total = c.Decimal(precision: 18, scale: 2),
                        Iva = c.Decimal(precision: 18, scale: 2),
                        Cod_Mantenimiento = c.Int(),
                        Cli_Documento = c.Int(nullable: false),
                        Cli_Tipo_Documento = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Clientes", t => new { t.Cli_Tipo_Documento, t.Cli_Documento }, cascadeDelete: true)
                .ForeignKey("dbo.Mantenimientos", t => t.Cod_Mantenimiento)
                .Index(t => t.Cod_Mantenimiento)
                .Index(t => new { t.Cli_Tipo_Documento, t.Cli_Documento });
            
            CreateTable(
                "dbo.Mantenimientos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Cod_Placa = c.String(maxLength: 6),
                        Fecha = c.DateTime(),
                        Mec_Tipo_Documento = c.String(nullable: false, maxLength: 128),
                        Mec_Documento = c.Int(nullable: false),
                        Estado = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Estados_Mantenimiento", t => t.Estado)
                .ForeignKey("dbo.Mecanicos", t => new { t.Mec_Tipo_Documento, t.Mec_Documento }, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculos", t => t.Cod_Placa)
                .Index(t => t.Cod_Placa)
                .Index(t => new { t.Mec_Tipo_Documento, t.Mec_Documento })
                .Index(t => t.Estado);
            
            CreateTable(
                "dbo.Estados_Mantenimiento",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre_Estado = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Fotos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Ruta = c.String(maxLength: 200),
                        Cod_Mantenimiento = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Mantenimientos", t => t.Cod_Mantenimiento)
                .Index(t => t.Cod_Mantenimiento);
            
            CreateTable(
                "dbo.Mecanicos",
                c => new
                    {
                        Tipo_Documento = c.String(nullable: false, maxLength: 128),
                        Documento = c.Int(nullable: false),
                        Primer_Nombre = c.String(maxLength: 30),
                        Segundo_Nombre = c.String(maxLength: 30),
                        Primer_Apellido = c.String(maxLength: 30),
                        Segundo_Apellido = c.String(maxLength: 30),
                        Celular = c.String(maxLength: 10),
                        Direccion = c.String(maxLength: 200),
                        Email = c.String(maxLength: 100),
                        Estado = c.Int(),
                    })
                .PrimaryKey(t => new { t.Tipo_Documento, t.Documento })
                .ForeignKey("dbo.Estados_Mecanicos", t => t.Estado)
                .ForeignKey("dbo.Tipos_Documento", t => t.Tipo_Documento, cascadeDelete: true)
                .Index(t => t.Tipo_Documento)
                .Index(t => t.Estado);
            
            CreateTable(
                "dbo.Estados_Mecanicos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre_Estado = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Tipos_Documento",
                c => new
                    {
                        Codigo = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(maxLength: 20),
                        Abreviatura = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Presupuesto_X_Mantenimiento",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Cod_Placa = c.String(maxLength: 6),
                        Cod_Mantenimiento = c.Int(nullable: false),
                        Presupuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Mantenimientos", t => t.Cod_Mantenimiento, cascadeDelete: true)
                .ForeignKey("dbo.Vehiculos", t => t.Cod_Placa)
                .Index(t => t.Cod_Placa)
                .Index(t => t.Cod_Mantenimiento);
            
            CreateTable(
                "dbo.Vehiculos",
                c => new
                    {
                        Placa = c.String(nullable: false, maxLength: 6),
                        Color = c.String(maxLength: 30),
                        Cod_Marca = c.Int(),
                        Cli_Documento = c.Int(nullable: false),
                        Cli_Tipo_Documento = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Placa)
                .ForeignKey("dbo.Clientes", t => new { t.Cli_Tipo_Documento, t.Cli_Documento }, cascadeDelete: true)
                .ForeignKey("dbo.Marcas", t => t.Cod_Marca)
                .Index(t => t.Cod_Marca)
                .Index(t => new { t.Cli_Tipo_Documento, t.Cli_Documento });
            
            CreateTable(
                "dbo.Marcas",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre_Marca = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Repuestos_X_Mantenimientos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Unidades = c.Int(),
                        Tiempo_Estimado = c.Int(),
                        Cod_Repuesto = c.Int(),
                        Cod_Mantenimiento = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Mantenimientos", t => t.Cod_Mantenimiento)
                .ForeignKey("dbo.Repuestos", t => t.Cod_Repuesto)
                .Index(t => t.Cod_Repuesto)
                .Index(t => t.Cod_Mantenimiento);
            
            CreateTable(
                "dbo.Repuestos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre_Repuesto = c.String(maxLength: 100),
                        Precio_Unitario = c.Decimal(precision: 18, scale: 2),
                        Unidades_Inventario = c.Int(),
                        Proveedor = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Servicios_X_Mantenimientos",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Tiempo_Estimado = c.Int(),
                        Cod_Servicio = c.Int(),
                        Cod_Mantenimiento = c.Int(),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Mantenimientos", t => t.Cod_Mantenimiento)
                .ForeignKey("dbo.Servicios", t => t.Cod_Servicio)
                .Index(t => t.Cod_Servicio)
                .Index(t => t.Cod_Mantenimiento);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        Codigo = c.Int(nullable: false, identity: true),
                        Nombre_Servicio = c.String(maxLength: 100),
                        Precio = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Servicios_X_Mantenimientos", "Cod_Servicio", "dbo.Servicios");
            DropForeignKey("dbo.Servicios_X_Mantenimientos", "Cod_Mantenimiento", "dbo.Mantenimientos");
            DropForeignKey("dbo.Repuestos_X_Mantenimientos", "Cod_Repuesto", "dbo.Repuestos");
            DropForeignKey("dbo.Repuestos_X_Mantenimientos", "Cod_Mantenimiento", "dbo.Mantenimientos");
            DropForeignKey("dbo.Presupuesto_X_Mantenimiento", "Cod_Placa", "dbo.Vehiculos");
            DropForeignKey("dbo.Vehiculos", "Cod_Marca", "dbo.Marcas");
            DropForeignKey("dbo.Mantenimientos", "Cod_Placa", "dbo.Vehiculos");
            DropForeignKey("dbo.Vehiculos", new[] { "Cli_Tipo_Documento", "Cli_Documento" }, "dbo.Clientes");
            DropForeignKey("dbo.Presupuesto_X_Mantenimiento", "Cod_Mantenimiento", "dbo.Mantenimientos");
            DropForeignKey("dbo.Mantenimientos", new[] { "Mec_Tipo_Documento", "Mec_Documento" }, "dbo.Mecanicos");
            DropForeignKey("dbo.Mecanicos", "Tipo_Documento", "dbo.Tipos_Documento");
            DropForeignKey("dbo.Clientes", "Tipo_Documento", "dbo.Tipos_Documento");
            DropForeignKey("dbo.Mecanicos", "Estado", "dbo.Estados_Mecanicos");
            DropForeignKey("dbo.Fotos", "Cod_Mantenimiento", "dbo.Mantenimientos");
            DropForeignKey("dbo.Facturas", "Cod_Mantenimiento", "dbo.Mantenimientos");
            DropForeignKey("dbo.Mantenimientos", "Estado", "dbo.Estados_Mantenimiento");
            DropForeignKey("dbo.Facturas", new[] { "Cli_Tipo_Documento", "Cli_Documento" }, "dbo.Clientes");
            DropIndex("dbo.Servicios_X_Mantenimientos", new[] { "Cod_Mantenimiento" });
            DropIndex("dbo.Servicios_X_Mantenimientos", new[] { "Cod_Servicio" });
            DropIndex("dbo.Repuestos_X_Mantenimientos", new[] { "Cod_Mantenimiento" });
            DropIndex("dbo.Repuestos_X_Mantenimientos", new[] { "Cod_Repuesto" });
            DropIndex("dbo.Vehiculos", new[] { "Cli_Tipo_Documento", "Cli_Documento" });
            DropIndex("dbo.Vehiculos", new[] { "Cod_Marca" });
            DropIndex("dbo.Presupuesto_X_Mantenimiento", new[] { "Cod_Mantenimiento" });
            DropIndex("dbo.Presupuesto_X_Mantenimiento", new[] { "Cod_Placa" });
            DropIndex("dbo.Mecanicos", new[] { "Estado" });
            DropIndex("dbo.Mecanicos", new[] { "Tipo_Documento" });
            DropIndex("dbo.Fotos", new[] { "Cod_Mantenimiento" });
            DropIndex("dbo.Mantenimientos", new[] { "Estado" });
            DropIndex("dbo.Mantenimientos", new[] { "Mec_Tipo_Documento", "Mec_Documento" });
            DropIndex("dbo.Mantenimientos", new[] { "Cod_Placa" });
            DropIndex("dbo.Facturas", new[] { "Cli_Tipo_Documento", "Cli_Documento" });
            DropIndex("dbo.Facturas", new[] { "Cod_Mantenimiento" });
            DropIndex("dbo.Clientes", new[] { "Tipo_Documento" });
            DropTable("dbo.Servicios");
            DropTable("dbo.Servicios_X_Mantenimientos");
            DropTable("dbo.Repuestos");
            DropTable("dbo.Repuestos_X_Mantenimientos");
            DropTable("dbo.Marcas");
            DropTable("dbo.Vehiculos");
            DropTable("dbo.Presupuesto_X_Mantenimiento");
            DropTable("dbo.Tipos_Documento");
            DropTable("dbo.Estados_Mecanicos");
            DropTable("dbo.Mecanicos");
            DropTable("dbo.Fotos");
            DropTable("dbo.Estados_Mantenimiento");
            DropTable("dbo.Mantenimientos");
            DropTable("dbo.Facturas");
            DropTable("dbo.Clientes");
        }
    }
}
