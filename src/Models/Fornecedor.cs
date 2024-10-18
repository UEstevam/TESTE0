using System.ComponentModel.DataAnnotations.Schema;

namespace src.Models
{
    [Table("fornecedor")]
    public class Fornecedor
    {
        public int Id { get; set; }

        // Propriedade da chave estrangeira
        [ForeignKey("Usuario")]
        [Column("id_user")]
        public int IdUser { get; set; }

        // Propriedade de navegação
        public Usuario Usuario { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        [Column("endereco_rua")]
        public string EnderecoRua { get; set; }

        [Column("endereco_numero")]
        public string EnderocoNumero { get; set; }

        [Column("endereco_uf")]
        public string EnderecoUF { get; set; }

        [Column("endereco_cep")]
        public string EnderecoCEP { get; set; }

    }
}
