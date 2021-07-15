using Entity.Entities.Enuns;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity.Entities.Persons.Users
{
    public class ApplicationUser : IdentityUser
    {
        //============================ DADOS PESSOAIS ====================================

        [Column("NOME")]
        [MaxLength(255)]
        [Display(Name = "NOME")]
        public string Name { get; set; }

        [Column("IDADE")]
        [Display(Name = "Idade")]
        public int BirthDate { get; set; }

        //============================ DOCUMENTOS ========================================

        [Column("CPF")]
        [MaxLength(50)]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("RG")]
        [MaxLength(50)]
        [Display(Name = "RG")]
        public string RG { get; set; }

        //============================ ENDEREÇO ==========================================

        [Column("CEP")]
        [MaxLength(15)]
        [DisplayName("CEP")]
        public string PostCode { get; set; }

        [Column("ENDERECO")]
        [MaxLength(255)]
        [DisplayName("ENDEREÇO")]
        public string Adress { get; set; }

        [Column("COMPLEMENTOENDERECO")]
        [MaxLength(450)]
        [DisplayName("COMPLEMENTO ENDEREÇO")]
        public string complementAdress { get; set; }

        [Column("CIDADE")]
        [MaxLength(450)]
        [DisplayName("CIDADE")]
        public string City { get; set; }

        [Column("ESTADO")]
        [DisplayName("ESTADO")]
        public bool State { get; set; }

        //============================ CONTATOS ==========================================

        [Column("CELULAR")]
        [MaxLength(20)]
        [DisplayName("CELULAR")]
        public string CellPhone { get; set; }

        [Column("TELEFONE")]
        [MaxLength(20)]
        [DisplayName("TELEFONE_FIXO")]
        public string Telephone { get; set; }

        //============================ TIPOS DE AUTORIZAÇÃO ==============================

        [Column("TIPO")]
        [DisplayName("TIPO_USUÁRIO")]
        public UserType Type { get; set; }
    }
}
