using Entity.Notifications;
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
        [Display(Name = "Nome")]
        public string Name { get; set; }


        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Valor")]
        public decimal Value { get; set; }

        [Column("Estado")]
        [Display(Name = "Estado")]
        public bool State { get; set; }

    }
}
