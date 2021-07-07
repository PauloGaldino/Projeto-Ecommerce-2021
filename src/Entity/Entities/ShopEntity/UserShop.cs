using Entity.Entities.Enuns;
using Entity.Entities.Persons.Users;
using Entity.Entities.ProductEntity;
using Entity.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entity.Entities.ShopEntity
{
    [Table ("CompraUsuario")]
    public class UserShop: Notifiers
    {
        [Column("USUARIOID")]
        [Display(Name ="CÓDIGO")]
        public int Id { get; set; }

        [Column("ESTADO")]
        [Display(Name ="ESTADO_COMPRA")]
        public ShopStatus Status { get; set; }

        [Column("QUANTIDADE")]
        [Display(Name = "QUANTIDADE")]
        public int Quantity { get; set; }

        //Relacionamento entre as tabelas
        
        [Display(Name ="USUÁRIO")]
        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public int UserId { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        [Display(Name ="PRODUTO")]
        [ForeignKey("Product")]
        [Column(Order = 1)]
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }

    }
}
