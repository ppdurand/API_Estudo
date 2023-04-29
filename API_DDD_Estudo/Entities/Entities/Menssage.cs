using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_MENSSAGE")]
    public class Menssage : Notifies
    {
        [Column("MSN_ID")]
        public int Id { get; set; }
        [Column("MSN_TITULO")]
        [MaxLength(250)]
        public string Titulo { get; set; }
        [Column("MSN_ATIVO")]
        public bool Ativo { get; set; }

        [Column("MSN_DATA_CADASTRO")]
        public DateTime DataCadastro { get; set; }

        [Column("MSN_DATA_ALTERACAO")]
        public DateTime DataAlteração { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string userId { get; set; }

        public virtual ApplicationUser applicationUser { get; set; }
         
        
    }
}
