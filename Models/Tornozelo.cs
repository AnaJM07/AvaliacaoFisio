namespace FisioForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tornozelo")]
    public partial class Tornozelo
    {
        public int id { get; set; }

        public int? Plantiflexao_Direita { get; set; }

        public int? Plantiflexao_Esquerda { get; set; }

        [StringLength(255)]
        public string Plantiflexao_Parametro { get; set; }

        [StringLength(255)]
        public string Plantiflexao_Conclusao { get; set; }

        public int? Dorsiflexao_Direita { get; set; }

        public int? Dorsiflexao_Esquerda { get; set; }

        [StringLength(255)]
        public string Dorsiflexao_Parametro { get; set; }

        [StringLength(255)]
        public string Dorsiflexao_Conclusao { get; set; }
    }
}
