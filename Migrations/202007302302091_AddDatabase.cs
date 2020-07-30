namespace FisioForms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adm_Cervical",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Flexao_Direita = c.Int(),
                        Flexao_Esquerda = c.Int(),
                        Flexao_Parametro = c.String(maxLength: 255),
                        Flexao_Conclusao = c.String(maxLength: 255),
                        Extensao_Direita = c.Int(),
                        Extensao_Esquerda = c.Int(),
                        Extensao_Parametro = c.String(maxLength: 255),
                        Extensao_Conclusao = c.String(maxLength: 255),
                        Rotacao_Direita = c.Int(),
                        Rotacao_Esquerda = c.Int(),
                        Rotacao_Parametro = c.String(maxLength: 255),
                        Rotacao_Conclusao = c.String(maxLength: 255),
                        Inclinacao_Direita = c.Int(),
                        Inclinacao_Esquerda = c.Int(),
                        Inclinacao_Parametro = c.String(maxLength: 255),
                        Inclinacao_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        CdPaciente = c.Int(nullable: false, identity: true),
                        nome = c.String(maxLength: 50),
                        responsavel = c.String(maxLength: 50),
                        sexo = c.String(maxLength: 10),
                        dtNascimento = c.DateTime(),
                        diagnostico = c.String(maxLength: 255),
                        qxPrincipal = c.String(maxLength: 255),
                        hma = c.String(maxLength: 500, unicode: false),
                        antoponetria = c.String(maxLength: 255),
                        antecendetesFam = c.String(maxLength: 255),
                        peso = c.Int(),
                        altura = c.Decimal(precision: 18, scale: 2),
                        fc = c.Int(),
                        fr = c.Int(),
                        pa = c.String(maxLength: 255),
                        temp = c.Int(),
                        estadoGeral = c.String(maxLength: 255),
                        locomocao = c.String(maxLength: 255),
                        inspecao = c.String(maxLength: 255),
                        palpacao = c.String(maxLength: 255),
                        forcaMuscular = c.String(maxLength: 255),
                        endereco = c.String(maxLength: 50),
                        cidade = c.String(maxLength: 50),
                        telefone = c.String(maxLength: 50),
                        email = c.String(maxLength: 100),
                        dor = c.Int(),
                        avaliacaoFun = c.String(maxLength: 255),
                        cirurgiaPrevias = c.String(maxLength: 255),
                        medicamentos = c.String(maxLength: 255),
                        terapiasPrevias = c.String(maxLength: 255),
                        terapiasConcomitantes = c.String(maxLength: 255),
                        examesComplementares = c.String(maxLength: 255),
                        DiagnosticoFisioterapeutico = c.String(maxLength: 255),
                        Objetivo = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Adm_Cotovelo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Flexao_Direita = c.Int(),
                        Flexao_Esquerda = c.Int(),
                        Flexao_Parametro = c.String(maxLength: 255),
                        Flexao_Conclusao = c.String(maxLength: 255),
                        Extensao_Direita = c.Int(),
                        Extensao_Esquerda = c.Int(),
                        Extensao_Parametro = c.String(maxLength: 255),
                        Extensao_Conclusao = c.String(maxLength: 255),
                        Pronacao_Direita = c.Int(),
                        Pronacao_Esquerda = c.Int(),
                        Pronacao_Parametro = c.String(maxLength: 255),
                        Pronacao_Conclusao = c.String(maxLength: 255),
                        Supinacao_Direita = c.Int(),
                        Supinacao_Esquerda = c.Int(),
                        Supinacao_Parametro = c.String(maxLength: 255),
                        Supinacao_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Adm_Punho",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Flexao_Direita = c.Int(),
                        Flexao_Esquerda = c.Int(),
                        Flexao_Parametro = c.String(maxLength: 255),
                        Flexao_Conclusao = c.String(maxLength: 255),
                        Extensao_Direita = c.Int(),
                        Extensao_Esquerda = c.Int(),
                        Extensao_Parametro = c.String(maxLength: 255),
                        Extensao_Conclusao = c.String(maxLength: 255),
                        DesvUlnar_Direita = c.Int(),
                        DesvUlnar_Esquerda = c.Int(),
                        DesvUlnar_Parametro = c.String(maxLength: 255),
                        DesvUlnar_Conclusao = c.String(maxLength: 255),
                        DesvRadial_Direita = c.Int(),
                        DesvRadial_Esquerda = c.Int(),
                        DesvRadial_Parametro = c.String(maxLength: 255),
                        DesvRadial_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Adm_Tronco",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Flexao_Direita = c.Int(),
                        Flexao_Esquerda = c.Int(),
                        Flexao_Parametro = c.String(maxLength: 255),
                        Flexao_Conclusao = c.String(maxLength: 255),
                        Extensao_Direita = c.Int(),
                        Extensao_Esquerda = c.Int(),
                        Extensao_Parametro = c.String(maxLength: 255),
                        Extensao_Conclusao = c.String(maxLength: 255),
                        Rotacao_Direita = c.Int(),
                        Rotacao_Esquerda = c.Int(),
                        Rotacao_Parametro = c.String(maxLength: 255),
                        Rotacao_Conclusao = c.String(maxLength: 255),
                        Inclinacao_Direita = c.Int(),
                        Inclinacao_Esquerda = c.Int(),
                        Inclinacao_Parametro = c.String(maxLength: 255),
                        Inclinacao_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Joelho",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Flexao_Direita = c.Int(),
                        Flexao_Esquerda = c.Int(),
                        Flexao_Parametro = c.String(maxLength: 255),
                        Flexao_Conclusao = c.String(maxLength: 255),
                        Extensao_Direita = c.Int(),
                        Extensao_Esquerda = c.Int(),
                        Extensao_Parametro = c.String(maxLength: 255),
                        Extensao_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Ombro",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Flexao_Direita = c.Int(),
                        Flexao_Esquerda = c.Int(),
                        Flexao_Parametro = c.String(maxLength: 255),
                        Flexao_Conclusao = c.String(maxLength: 255),
                        Extensao_Direita = c.Int(),
                        Extensao_Esquerda = c.Int(),
                        Extensao_Parametro = c.String(maxLength: 255),
                        Extensao_Conclusao = c.String(maxLength: 255),
                        Abducao_Direita = c.Int(),
                        Abducao_Esquerda = c.Int(),
                        Abducao_Parametro = c.String(maxLength: 255),
                        Abducao_Conclusao = c.String(maxLength: 255),
                        Aducao_Direita = c.Int(),
                        Aducao_Esquerda = c.Int(),
                        Aducao_Parametro = c.String(maxLength: 255),
                        Aducao_Conclusao = c.String(maxLength: 255),
                        RotInerna_Direita = c.Int(),
                        RotInerna_Esquerda = c.Int(),
                        RotInerna_Parametro = c.String(maxLength: 255),
                        RotInerna_Conclusao = c.String(maxLength: 255),
                        RotExterna_Direita = c.Int(),
                        RotExterna_Esquerda = c.Int(),
                        RotExterna_Parametro = c.String(maxLength: 255),
                        RotExterna_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Pe",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Inversao_Direita = c.Int(),
                        Inversao_Esquerda = c.Int(),
                        Inversao_Parametro = c.String(maxLength: 255),
                        Inversao_Conclusao = c.String(maxLength: 255),
                        Eversao_Direita = c.Int(),
                        Eversao_Esquerda = c.Int(),
                        Eversao_Parametro = c.String(maxLength: 255),
                        Eversao_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Quadril",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Flexao_Direita = c.Int(),
                        Flexao_Esquerda = c.Int(),
                        Flexao_Parametro = c.String(maxLength: 255),
                        Flexao_Conclusao = c.String(maxLength: 255),
                        Extensao_Direita = c.Int(),
                        Extensao_Esquerda = c.Int(),
                        Extensao_Parametro = c.String(maxLength: 255),
                        Extensao_Conclusao = c.String(maxLength: 255),
                        Abducao_Direita = c.Int(),
                        Abducao_Esquerda = c.Int(),
                        Abducao_Parametro = c.String(maxLength: 255),
                        Abducao_Conclusao = c.String(maxLength: 255),
                        Aducao_Direita = c.Int(),
                        Aducao_Esquerda = c.Int(),
                        Aducao_Parametro = c.String(maxLength: 255),
                        Aducao_Conclusao = c.String(maxLength: 255),
                        RotInerna_Direita = c.Int(),
                        RotInerna_Esquerda = c.Int(),
                        RotInerna_Parametro = c.String(maxLength: 255),
                        RotInerna_Conclusao = c.String(maxLength: 255),
                        RotExterna_Direita = c.Int(),
                        RotExterna_Esquerda = c.Int(),
                        RotExterna_Parametro = c.String(maxLength: 255),
                        RotExterna_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
            CreateTable(
                "dbo.Tornozelo",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Plantiflexao_Direita = c.Int(),
                        Plantiflexao_Esquerda = c.Int(),
                        Plantiflexao_Parametro = c.String(maxLength: 255),
                        Plantiflexao_Conclusao = c.String(maxLength: 255),
                        Dorsiflexao_Direita = c.Int(),
                        Dorsiflexao_Esquerda = c.Int(),
                        Dorsiflexao_Parametro = c.String(maxLength: 255),
                        Dorsiflexao_Conclusao = c.String(maxLength: 255),
                        CdPaciente = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Paciente", t => t.CdPaciente, cascadeDelete: true)
                .Index(t => t.CdPaciente);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tornozelo", "CdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Quadril", "CdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Pe", "CdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Ombro", "CdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Joelho", "CdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Adm_Tronco", "CdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Adm_Punho", "CdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Adm_Cotovelo", "CdPaciente", "dbo.Paciente");
            DropForeignKey("dbo.Adm_Cervical", "CdPaciente", "dbo.Paciente");
            DropIndex("dbo.Tornozelo", new[] { "CdPaciente" });
            DropIndex("dbo.Quadril", new[] { "CdPaciente" });
            DropIndex("dbo.Pe", new[] { "CdPaciente" });
            DropIndex("dbo.Ombro", new[] { "CdPaciente" });
            DropIndex("dbo.Joelho", new[] { "CdPaciente" });
            DropIndex("dbo.Adm_Tronco", new[] { "CdPaciente" });
            DropIndex("dbo.Adm_Punho", new[] { "CdPaciente" });
            DropIndex("dbo.Adm_Cotovelo", new[] { "CdPaciente" });
            DropIndex("dbo.Adm_Cervical", new[] { "CdPaciente" });
            DropTable("dbo.Tornozelo");
            DropTable("dbo.Quadril");
            DropTable("dbo.Pe");
            DropTable("dbo.Ombro");
            DropTable("dbo.Joelho");
            DropTable("dbo.Adm_Tronco");
            DropTable("dbo.Adm_Punho");
            DropTable("dbo.Adm_Cotovelo");
            DropTable("dbo.Paciente");
            DropTable("dbo.Adm_Cervical");
        }
    }
}
