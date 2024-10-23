using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    [Table("categoria")]
    public class Categoria
    {
        public int Id { get; set; }

        // Propriedade da chave estrangeira
        [ForeignKey("Usuario")]
        [Column("id_user")]
        public int IdUser { get; set; }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        [Column("criado_em")]
        public DateTime CriadoEm { get; set; }
    }
}
