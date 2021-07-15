using Entity.Entities.Persons.Users;
using Entity.Notifications;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.ProductEntity
{
    [Table("Produto")]

    public class Product : Notifiers
    {
        [Column("Id")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("Nome")]
        [MaxLength(255)]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Column("DESCRICAO")]
        [MaxLength(150)]
        [DisplayName("DESCRIÇÃO")]
        public string Description { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Column("QUANTIDADEESTOQUE")]
        [DisplayName("QUANTIDADE_ESTOQUE")]
        public int StockQuantity { get; set; }

        [Display(Name = "USUÁRIO")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public bool State { get; set; }

        [Column("DATACADASTRO")]
        [Display(Name = "DATA_CADASTRO")]
        public DateTime RegisterDate { get; set; }

        [Column("DATAALTERACAO")]
        [Display(Name = "DATA_ALTERAÇÃO")]
        public DateTime ChangeDate { get; set; }
    }
}
