namespace FisioForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Joelho")]
    public partial class Joelho
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
    }
}
