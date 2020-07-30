namespace FisioForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pe")]
    public partial class Pe
    {
        public int id { get; set; }

        public int? Inversao_Direita { get; set; }

        public int? Inversao_Esquerda { get; set; }

        [StringLength(255)]
        public string Inversao_Parametro { get; set; }

        [StringLength(255)]
        public string Inversao_Conclusao { get; set; }

        public int? Eversao_Direita { get; set; }

        public int? Eversao_Esquerda { get; set; }

        [StringLength(255)]
        public string Eversao_Parametro { get; set; }

        [StringLength(255)]
        public string Eversao_Conclusao { get; set; }

        public int CdPaciente { get; set; }

        [ForeignKey("CdPaciente")]
        public Paciente Paciente { get; set; }
    }
}
