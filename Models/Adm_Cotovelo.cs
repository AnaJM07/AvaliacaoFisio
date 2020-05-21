namespace FisioForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Adm_Cotovelo
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

        public int? Pronacao_Direita { get; set; }

        public int? Pronacao_Esquerda { get; set; }

        [StringLength(255)]
        public string Pronacao_Parametro { get; set; }

        [StringLength(255)]
        public string Pronacao_Conclusao { get; set; }

        public int? Supinacao_Direita { get; set; }

        public int? Supinacao_Esquerda { get; set; }

        [StringLength(255)]
        public string Supinacao_Parametro { get; set; }

        [StringLength(255)]
        public string Supinacao_Conclusao { get; set; }
    }
}
