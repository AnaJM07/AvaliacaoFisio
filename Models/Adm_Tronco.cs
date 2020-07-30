namespace FisioForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Adm_Tronco
    {
        public int id { get; set; }

        public int? Flexao_Direita { get; set; }

        public int? Flexao_Esquerda { get; set; }

        [StringLength(255)]
        public string Flexao_Parametro { get; set; }

        [StringLength(255)]
        public string Flexao_Conclusao { get; set; }

        public int? Extensao_Direita { get; set; }

        public int? Extensao_Esquerda { get; set; }

        [StringLength(255)]
        public string Extensao_Parametro { get; set; }

        [StringLength(255)]
        public string Extensao_Conclusao { get; set; }

        public int? Rotacao_Direita { get; set; }

        public int? Rotacao_Esquerda { get; set; }

        [StringLength(255)]
        public string Rotacao_Parametro { get; set; }

        [StringLength(255)]
        public string Rotacao_Conclusao { get; set; }

        public int? Inclinacao_Direita { get; set; }

        public int? Inclinacao_Esquerda { get; set; }

        [StringLength(255)]
        public string Inclinacao_Parametro { get; set; }

        [StringLength(255)]
        public string Inclinacao_Conclusao { get; set; }

        public int CdPaciente { get; set; }

        [ForeignKey("CdPaciente")]
        public Paciente Paciente { get; set; }
    }
}
