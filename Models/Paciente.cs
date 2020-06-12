namespace FisioForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paciente")]
    public partial class Paciente
    {
        public int id { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(50)]
        public string responsavel { get; set; }

        [StringLength(10)]
        public string sexo { get; set; }

        public DateTime? dtNascimento { get; set; }

        [StringLength(255)]
        public string diagnostico { get; set; }

        [StringLength(255)]
        public string qxPrincipal { get; set; }

        [StringLength(500)]
        public string hma { get; set; }

        [StringLength(255)]
        public string antoponetria { get; set; }

        [StringLength(255)]
        public string antecendetesFam{ get; set; }

        public int? peso { get; set; }

        public decimal? altura { get; set; }

        public int? fc { get; set; }

        public int? fr { get; set; }

        [StringLength(255)]
        public string pa { get; set; }

        public int? temp { get; set; }

        [StringLength(255)]
        public string estadoGeral { get; set; }

        [StringLength(255)]
        public string locomocao { get; set; }

        [StringLength(255)]
        public string inspecao { get; set; }

        [StringLength(255)]
        public string palpacao { get; set; }

        [StringLength(255)]
        public string forcaMuscular { get; set; }

        [StringLength(50)]
        public string endereco { get; set; }

        [StringLength(50)]
        public string cidade { get; set; }

        [StringLength(50)]
        public string telefone { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        public int? dor { get; set; }

        [StringLength(255)]
        public string avaliacaoFun { get; set; }

        [StringLength(255)]
        public string cirurgiaPrevias { get; set; }

        [StringLength(255)]
        public string medicamentos { get; set; }

        [StringLength(255)]
        public string terapiasPrevias { get; set; }

        [StringLength(255)]
        public string terapiasConcomitantes { get; set; }

        [StringLength(255)]
        public string examesComplementares { get; set; }

        [StringLength(255)]
        public string DiagnosticoFisioterapeutico { get; set; }

        [StringLength(255)]
        public string Objetivo { get; set; }
    }
}
