namespace FisioForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Quadril")]
    public partial class Quadril
    {
        public int id { get; set; }

        public int? Flexao_Direita { get; set; }
//C:\Users\Silva\Desktop\GitHub\AnaJM07\AndreFisio\Models\Quadril.cs
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

        public int? Abducao_Direita { get; set; }

        public int? Abducao_Esquerda { get; set; }

        [StringLength(255)]
        public string Abducao_Parametro { get; set; }

        [StringLength(255)]
        public string Abducao_Conclusao { get; set; }

        public int? Aducao_Direita { get; set; }

        public int? Aducao_Esquerda { get; set; }

        [StringLength(255)]
        public string Aducao_Parametro { get; set; }

        [StringLength(255)]
        public string Aducao_Conclusao { get; set; }

        public int? RotInerna_Direita { get; set; }

        public int? RotInerna_Esquerda { get; set; }

        [StringLength(255)]
        public string RotInerna_Parametro { get; set; }

        [StringLength(255)]
        public string RotInerna_Conclusao { get; set; }

        public int? RotExterna_Direita { get; set; }

        public int? RotExterna_Esquerda { get; set; }

        [StringLength(255)]
        public string RotExterna_Parametro { get; set; }

        [StringLength(255)]
        public string RotExterna_Conclusao { get; set; }

        public int CdPaciente { get; set; }

        [ForeignKey("CdPaciente")]
        public Paciente Paciente { get; set; }
    }
}
