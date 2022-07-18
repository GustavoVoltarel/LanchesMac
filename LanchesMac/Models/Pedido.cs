using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "É necessário inserir um nome")]
        [StringLength(50)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É necessário inserir um sobrenome")]
        [StringLength(100)]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "É necessário inserir um endereço")]
        [StringLength(200)]
        [Display(Name = "Endereço")]
        public string Endereco1 { get; set; }

        [StringLength(200)]
        [Display(Name = "Complemento")]
        public string Endereco2 { get; set; }

        [Required(ErrorMessage = "É necessário inserir um CEP válido")]
        [Display(Name = "CEP")]
        [StringLength(10, MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "É necessário inserir o estado")]
        [StringLength(10)]
        public string Estado { get; set; }

        [Required(ErrorMessage = "É necessário inserir a cidade")]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "É necessário inserir um telefone")]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "É necessário inserir um e-mail")]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Formato de e-mail inválido")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Total do Pedido")]
        public decimal PedidoTotal { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Itens do pedido")]
        public int TotalItensPedido { get; set; }

        [Display(Name = "Data do pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm", ApplyFormatInEditMode =true)]
        public DateTime PedidoEnviado { get; set; }

        [Display(Name = "Data envio do pedido")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm", ApplyFormatInEditMode = true)]
        public DateTime? PedidoEntregueEm { get; set; }

        public List<PedidoDetalhe> PedidoItens { get; set; }
    }
}
